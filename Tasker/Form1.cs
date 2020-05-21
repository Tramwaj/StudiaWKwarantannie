using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            teachers = Data.InitialTeachers.Provide().ToList();
            subjects = Data.InitialSubjects.Provide(teachers).ToList();
            activities = new Activities();
            cklSubjects.Items.AddRange(subjects.Select(s => s.Name).ToArray());
            DisplayFilter = new ActivityDisplayFilter();
            ShowEvents();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DisplayFilter.Set(calendar.SelectionStart, calendar.SelectionEnd);
            ShowEvents();
        }
        private void btnCancelCalendar_Click(object sender, EventArgs e)
        {
            DisplayFilter.Disable();            
        }
        private void ShowEvents()
        {
            var bubek = activities.All.Select(x => x.Time).Distinct();
            dlvActivities.SetObjects(DisplayFilter.Apply(activities.All));
            //foreach (var date in activities.All.Select(x=>x.Time).Distinct())
            //{
            //    calendar.AddBoldedDate(date);
            //}
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
        
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmed = MessageBox.Show(
                "Czy naprawdę usunąć zapis?", "Usunięcie", MessageBoxButtons.OKCancel);
            if (deleteConfirmed == DialogResult.OK)
            {
                activities.All.Remove(dlvActivities.SelectedObjects.OfType<Activity>().First());
            }
            if (deleteConfirmed == DialogResult.Cancel)
            {

            }
            ShowEvents();
        }        

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string _file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "activities.xml";
            Workers.Serializator.Serialize("act.bin", activities);
            //using (TextWriter writer = new StreamWriter(file))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(Activities));
            //    serializer.Serialize(writer, activities);
            //    writer.Close();
            //}
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string _file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "activities.xml";
            activities = Workers.Serializator.Deserialize<Activities>("act.bin");
            ShowEvents();
        }

        private void dlvActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Activity> temp = dlvActivities.SelectedObjects.OfType<Activity>().ToList();
            ////olvEvents.AccessibilityObjectacce
            //if (temp.Any())
            //{
            //    activities.All=activities.All.Select(x => { x.Time = x.Time.AddHours(1); return x; }).ToList();
            //    //temp.First().Subject.Name = "Bobki";
            //    string _subjectName = temp.First().Time.ToString();//.GetType().ToString();
            //                                           //if (!String.IsNullOrEmpty(typ))
            //                                           //{
            //    label1.Text = _subjectName;
            //    //}
            //}
            //var chosenActivity = activities.All.Where(x=>x==)
        }
        
    }
}
