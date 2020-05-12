using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasker.Data;
using Tasker.Models;

namespace Tasker
{
    public partial class AddLesson : Form
    {
        private Lesson lesson;
        private ICollection<Subject> _subjects;
        public AddLesson(ICollection<Subject> subjects)
        {
            InitializeComponent();
            _subjects = subjects;
            cmbSubject.Items.AddRange(subjects.Select(s => s.ShortName).OrderBy(s => s).ToArray());
            SetComboBoxesToDefault();
        }

        public Lesson GetResult()
        {
            return lesson;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime _startTime = dtpDate.Value.Date;
            _startTime = _startTime.AddHours(Convert.ToInt32(cmbStartHour.SelectedItem));
            _startTime = _startTime.AddMinutes(Convert.ToInt32(cmbStartMinutes.SelectedItem));
            TimeSpan _duration = new TimeSpan
                (Convert.ToInt32(cmbDurationHours.SelectedItem)
                , Convert.ToInt32(cmbDurationMinutes.SelectedItem)
                , 0);

            lesson = new Lesson
                (_subjects.Where(s => s.ShortName.Equals(cmbSubject.SelectedItem)).First()
                , _startTime
                , _duration
                , (LessonType)cmbLessonType.SelectedIndex);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SetComboBoxesToDefault()
        {
            cmbDurationHours.SelectedIndex = 0;
            cmbDurationMinutes.SelectedIndex = 0;
            cmbStartHour.SelectedIndex = 0;
            cmbStartMinutes.SelectedIndex = 0;
            cmbSubject.SelectedIndex = 0;
            cmbLessonType.SelectedIndex = 0;
        }

    }
}
