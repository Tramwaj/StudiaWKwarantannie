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

            //bindingSource1.DataSource = activities.All;
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
        }
        private void btnCancelCalendar_Click(object sender, EventArgs e)
        {
            ShowAllEvents();
        }
        private void ShowAllEvents()
        {
            //dlvActivities.Refresh();
            dlvActivities.SetObjects(activities.All);
            //OLVDataObject

        }
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            //calendar.Invalidate();////
            DialogResult deleteConfirmed = MessageBox.Show(
                "Czy naprawdę usunąć zapis?", "Usunięcie", MessageBoxButtons.OKCancel);
            if (deleteConfirmed == DialogResult.OK)
            {

            }
            if (deleteConfirmed == DialogResult.Cancel)
            {

            }
        }

        

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "activities.xml";
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
            string file = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "activities.xml";
            activities = Workers.Serializator.Deserialize<Activities>("act.bin");
        }

        private void dlvActivities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
