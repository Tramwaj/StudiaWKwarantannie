using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasker.Models;

namespace Tasker
{
    public partial class Form1 : Form
    {
        private List<Teacher> teachers;
        private List<Subject> subjects;
        //private List<Activity> events;
        private Activities activities;
        public Form1()
        {
            InitializeComponent();
            teachers = Data.InitialTeachers.Provide().ToList();
            subjects = Data.InitialSubjects.Provide(teachers).ToList();
            activities = new Activities();
            
            cklSubjects.Items.AddRange(subjects.Select(s => s.Name).ToArray());

            bindingSource1.DataSource = activities.All;
            //bindingSource1.

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //monthCalendar1.
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
            ShowAllEvents();
        }
        private void UpdateEvents()
        {
            //lstEvents.Items.Clear();
            //lstEvents.Items.AddRange(events.ToString());
        }
        private void ShowAllEvents()
        {
            dlvActivities.Refresh();
            //dlvActivities.SetObjects(activities.All);            
            //OLVDataObject
            
        }       
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            calendar.Invalidate();////
            DialogResult deleteConfirmed = MessageBox.Show(
                "Czy naprawdę usunąć zapis?", "Usunięcie", MessageBoxButtons.OKCancel);
            if (deleteConfirmed == DialogResult.OK)
            {

            }
            if (deleteConfirmed == DialogResult.Cancel)
            {

            }
        }

        private void olvEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Lesson> temp = dlvActivities.SelectedObjects.OfType<Lesson>().ToList();
            //olvEvents.AccessibilityObjectacce
            if (temp.Any())
            {
                temp.First().Subject.Name = "Bobki";
                string typ = temp.First().Subject.Name;//.GetType().ToString();
                //if (!String.IsNullOrEmpty(typ))
                //{
                    label1.Text = typ;
                //}
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
