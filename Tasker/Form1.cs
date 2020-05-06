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
        private List<Event> events;
        public Form1()
        {
            InitializeComponent();
            teachers = Data.InitialTeachers.Provide();
            subjects = Data.InitialSubjects.Provide(teachers);
            events = new List<Event>();
            cklSubjects.Items.AddRange(subjects.Select(s => s.Name).ToArray());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //monthCalendar1.
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmed = MessageBox.Show(
                "Czy naprawdę usunąć zapis?", "Usunięcie", MessageBoxButtons.OKCancel);            
            if (deleteConfirmed == DialogResult.OK)
            {

            }
            if (deleteConfirmed == DialogResult.Cancel)
            {

            }
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            using (AddLesson addLesson = new AddLesson(subjects))
            {
                if (addLesson.ShowDialog() == DialogResult.OK)
                {
                    events.Add(addLesson.GetResult());
                    lstEvents.Items.Add(events.Last());
                }
            }            
        }
        private void UpdateEvents()
        {
            //lstEvents.Items.Clear();
            //lstEvents.Items.AddRange(events.ToString());
        }
    }
}
