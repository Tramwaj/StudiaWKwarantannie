using BrightIdeasSoftware;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
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
        public Form1()
        {
            InitializeComponent();
            //change to serialization
            //teachers = Data.InitialTeachers.Provide().ToList(); 
            //subjects = Data.InitialSubjects.Provide(teachers).ToList();
            //
            LoadSubjects();
            LoadTeachers();
            activities = new Activities();
            DisplayFilter = new ActivityDisplayFilter(cklSubjects.CheckedItems.Cast<string>());
            FormatActivitiesList();
            SetSubjects();
            ShowEvents();
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
            dlvActivities.SetObjects(DisplayFilter.Apply(activities.All));
            calendar.BoldedDates = activities.All.Select(x => x.Time).Distinct().ToArray();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            using (AddLesson addLesson = new AddLesson(subjects))
            {

                if (addLesson.ShowDialog() == DialogResult.OK)
                {
                    activities.Add(addLesson.GetResult());
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
                }
            }
            ShowEvents();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Activity selectedActivity = (Activity)dlvActivities.SelectedObject;
            try
            {
                using (EditDetails editDetails = new EditDetails((dynamic)selectedActivity))
                {
                    if (editDetails.ShowDialog() == DialogResult.OK)
                    {
                        activities.Replace(selectedActivity, editDetails.getResult());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak.", "błąd", MessageBoxButtons.OK);
            }
        }

        private void dlvActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity _chosenActivity = (Activity)dlvActivities.SelectedObject;
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
                        activities.Remove(dlvActivities.SelectedObjects.OfType<Activity>().First());
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

            string _file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "act.bin";
            Workers.Serializator.Serialize("act.bin", activities);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string _file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "act.bin";
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
        }


        // TO BE REMOVED:
        private void cklSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            teachers = Workers.Serializator.Deserialize<List<Teacher>>("teachers.bin");
        }
        private void LoadSubjects()
        {
            subjects = Workers.Serializator.Deserialize<List<Subject>>("subjects.bin");
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog("Gdzie zapisać?")
            {
                DefaultExtension = "bin"

            };
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var _tempAct = dlvActivities.SelectedObjects.OfType<Activity>().ToList();
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
    }
}
