using BrightIdeasSoftware;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tasker.Data;
using Tasker.Models;
using Tasker.Workers;

namespace Tasker
{
    public partial class Form1 : Form
    {
        private List<Teacher> teachers;
        private List<Subject> subjects;
        //private List<Activity> events;
        private Activities activities;
        private ActivityDisplayFilter DisplayFilter;
        bool _madeChanges = false;

        public Form1()
        {
            InitializeComponent();
            LoadSubjects();
            LoadTeachers();

            activities = new Activities();
            DisplayFilter = new ActivityDisplayFilter(cklSubjects.CheckedItems.Cast<string>());
            FormatActivitiesList();
            SetSubjects();
            ShowEvents();

            this.FormClosing += new FormClosingEventHandler(ConfirmExit);
        }

        private void ConfirmExit(object sender, FormClosingEventArgs e)
        {
            if (_madeChanges)
            {
                var _selectedOption = MessageBox.Show("A może by tak zmiany zapisać?", "U sur?", MessageBoxButtons.YesNoCancel);
                if (_selectedOption == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                if (_selectedOption == DialogResult.Yes) SaveAllActivitiesToDefaultLocation();
            } 
        }

        private void SetSubjects()
        {
            cklSubjects.Items.AddRange(subjects.Select(s => s.Name).ToArray());
            for (int i = 0; i < cklSubjects.Items.Count; i++)
            {
                cklSubjects.SetItemChecked(i, true);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DisplayFilter.SetDatesShown(calendar.SelectionStart, calendar.SelectionEnd);
            ShowEvents();
        }

        private void btnCancelCalendar_Click(object sender, EventArgs e)
        {
            DisplayFilter.DisableDates();
            ShowEvents();
        }

        private void ShowEvents()
        {
            CheckRadios();
            olvActivities.SetObjects(DisplayFilter.Apply(activities.All));
            calendar.BoldedDates = activities.All.Select(x => x.Time).Distinct().ToArray();
            //calendar
        }

        private void CheckRadios()
        {
            if (rdoShowAll.Checked == true) DisplayFilter.SetActivityTypesShown("All");
            if (rdoShowJobs.Checked == true) DisplayFilter.SetActivityTypesShown("Job");
            if (rdoShowLessons.Checked == true) DisplayFilter.SetActivityTypesShown("Lesson");
        }
        private void btnCopyActivity_Click(object sender, EventArgs e)
        {
            if (olvActivities.SelectedObjects.Count == 1)
            {
                Activity selectedActivity = (Activity)olvActivities.SelectedObject;
                if (selectedActivity is Job job)
                {
                    using (AddJob addJob = new AddJob(subjects,job))
                    {
                        if (addJob.ShowDialog() == DialogResult.OK)
                        {
                            activities.Add(addJob.GetResult());
                            _madeChanges = true;
                        }
                    }
                    ShowEvents();
                }
                if (selectedActivity is Lesson lesson)
                {
                    using (AddLesson addLesson = new AddLesson(subjects,lesson))
                    {
                        if (addLesson.ShowDialog() == DialogResult.OK)
                        {
                            activities.Add(addLesson.GetResult());
                            _madeChanges = true;
                        }
                    }
                    ShowEvents();
                }
            }
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            using (AddLesson addLesson = new AddLesson(subjects))
            {

                if (addLesson.ShowDialog() == DialogResult.OK)
                {
                    activities.Add(addLesson.GetResult());
                    _madeChanges = true;
                }
            }
            ShowEvents();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            using (AddJob addJob = new AddJob(subjects))
            {
                if (addJob.ShowDialog() == DialogResult.OK)
                {
                    activities.Add(addJob.GetResult());
                    _madeChanges = true;
                }
            }
            ShowEvents();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            bool ExactlyOneObjectSelected = olvActivities.SelectedObjects.Count == 1;
            if (ExactlyOneObjectSelected)
            {
                Activity selectedActivity = (Activity)olvActivities.SelectedObject;
                try
                {
                    using (EditDetails editDetails = new EditDetails(selectedActivity, subjects))
                    {
                        if (editDetails.ShowDialog() == DialogResult.OK)
                        {
                            var _resultActivity = editDetails.getResult();
                            activities.Replace(selectedActivity, _resultActivity);
                            _madeChanges = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Coś poszło nie tak.", "błąd", MessageBoxButtons.OK);
                }
                ShowEvents();
            }
            else MessageBox.Show("Należy wybrać jedną pozycję z listy", "błąd", MessageBoxButtons.OK);
        }

        private void dlvActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity _chosenActivity = (Activity)olvActivities.SelectedObject;
            if (_chosenActivity is null) { }
            else
            {
                olvNotes.SetObjects(_chosenActivity.Notes);
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmed = MessageBox.Show(
                "Czy naprawdę usunąć zapis?", "Usunięcie", MessageBoxButtons.OKCancel);
            if (deleteConfirmed == DialogResult.OK)
                try
                {
                    {
                        activities.Remove(olvActivities.SelectedObjects.OfType<Activity>().First());
                        _madeChanges = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Należy zaznaczyć JEDNO wydarzenie", "błąd", MessageBoxButtons.OK);
                }

            if (deleteConfirmed == DialogResult.Cancel)
            {

            }
            ShowEvents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAllActivitiesToDefaultLocation();            
        }
        private void SaveAllActivitiesToDefaultLocation()
        {            
            Workers.Serializator.Serialize("act.bin", activities);
            _madeChanges = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            activities = Workers.Serializator.Deserialize<Activities>("act.bin");
            ShowEvents();
        }

        private void cklSubjects_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayFilter.SetSubjectsShown(cklSubjects.CheckedItems.Cast<string>());
            ShowEvents();
        }

        private void FormatActivitiesList()
        {
            this.olvColDate.GroupKeyGetter = delegate (object rowObject)
            {
                Activity activity = (Activity)rowObject;
                return new DateTime(activity.Time.Year, activity.Time.Month, activity.Time.Day);
            };
            this.olvColDate.GroupKeyToTitleConverter = delegate (object groupKey)
            {
                return ((DateTime)groupKey).ToString("dddd-dd/MM/yyyy");
            };
            cmbState.SelectedIndex = 0;
            olvActivities.UseCellFormatEvents = true;

            this.olvActivities.FormatCell += delegate (object sender, FormatCellEventArgs e)
             {
                 if (e.ColumnIndex == this.olvColDate.Index)
                 {
                     try
                     {
                         Job activity = (Job)e.Model;
                         if ((activity.Time - DateTime.Now).Days < 0)
                         {
                             e.SubItem.ForeColor = Color.Red;
                         }

                         else if ((activity.Time - DateTime.Now).Days < 2)
                         {
                             e.SubItem.ForeColor = Color.Orange;
                         }
                     }
                     catch { }
                 }
             };
            olvActivities.FullRowSelect = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFilter.SetFilterByState(cmbState.SelectedIndex);
            ShowEvents();
        }


        private void btnEditSubjects_Click(object sender, EventArgs e)
        {
            using (EditSubjects editSubjects = new EditSubjects(subjects, teachers))
            {

                if (editSubjects.ShowDialog() == DialogResult.OK)
                {
                    subjects = editSubjects.GetSubjects().ToList();
                    teachers = editSubjects.GetTeachers().ToList();
                    SaveSubjects();
                    SaveTeachers();
                }
            }
            cklSubjects.Items.Clear();
            cklSubjects.Items.AddRange(subjects.Select(s => s.Name).ToArray());
            ShowEvents();
        }

        private void SaveTeachers()
        {
            Workers.Serializator.Serialize("teachers.bin", teachers);
        }

        private void SaveSubjects()
        {
            Workers.Serializator.Serialize("subjects.bin", subjects);
        }

        private void LoadTeachers()
        {
            try
            {
                teachers = Workers.Serializator.Deserialize<List<Teacher>>("teachers.bin");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Nie udało się zaimportować nauczycieli");
                teachers = new List<Teacher>();
            }
            //if (teachers.Count == 0)
            //{
            //   // teachers = InitialTeachers.Provide().ToList();
            //}
        }

        private void LoadSubjects()
        {
            try
            {
                subjects = Workers.Serializator.Deserialize<List<Subject>>("subjects.bin");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Nie udało się zaimportować przedmiotów");
                subjects = new List<Subject>();
            }
            //if (subjects.Count == 0)
            //{
            //   // subjects = InitialSubjects.Provide(teachers).ToList();
            //}
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog("Gdzie zapisać?")
            {
                DefaultExtension = "bin"

            };
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var _tempAct = olvActivities.SelectedObjects.OfType<Activity>().ToList();
                Workers.Serializator.Serialize(
                    openFileDialog.FileName
                    , _tempAct
                    );
            }
        }

        private void btnLoadSelected_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog("Gdzie zapisać?")
            {
                DefaultExtension = ".bin"

            };
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                activities.AddRange(Workers.Serializator.Deserialize<List<Activity>>(openFileDialog.FileName));
                ShowEvents();
            }
        }

        private void dlvActivities_DoubleClick(object sender, EventArgs e)
        {
            btnDetails_Click(sender, e);
        }


        private void rdoShowAll_CheckedChanged(object sender, EventArgs e)
        {
            ShowEvents();
        }

        private void rdoShowLessons_CheckedChanged(object sender, EventArgs e)
        {
            ShowEvents();
        }

        private void rdoShowJobs_CheckedChanged(object sender, EventArgs e)
        {
            ShowEvents();
        }
        // TO BE REMOVED:
        private void cklSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
