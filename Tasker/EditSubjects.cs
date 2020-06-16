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
    public partial class EditSubjects : Form
    {
        private ICollection<Subject> _subjects;
        private ICollection<Teacher> _teachers;
        public EditSubjects(ICollection<Subject> subjects, ICollection<Teacher> teachers)
        {
            _subjects = subjects;
            _teachers = teachers;
            InitializeComponent();

            cmbSubject.Items.AddRange(subjects.Select(s => s.Name).ToArray());
            cmbTeacher.Items.AddRange(teachers.Select(t => t.ToString()).ToArray());

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject _subject = _subjects.First(s => s.Name == (string)cmbSubject.SelectedItem);
            txtSubjectName.Text = _subject.Name;
            txtSubjectShortName.Text = _subject.ShortName;
            txtECTS.Text = _subject.ECTS.ToString();
            cmbTeacher.SelectedItem = _subject.Teacher.ToString();
        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher _teacher = _teachers.First(t => t.ToString() == (string)cmbTeacher.SelectedItem);
            txtTeacherFirstName.Text = _teacher.FirstName;
            txtTeacherSurname.Text = _teacher.LastName;
            txtEmail.Text = _teacher.Email;
            txtLink.Text = _teacher.Link;
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            //Walidacja

            //_subject.Name = txtSubjectName.Text = ;
            //_subject.ShortName = txtSubjectShortName.Text =;
            //txtECTS.Text = _subject.ECTS.ToString();
        }
        //private bool SubjectValidation
    }
}
