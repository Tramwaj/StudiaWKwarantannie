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
        private ICollection<Subject> subjects;
        private ICollection<Teacher> teachers;
        public EditSubjects(ICollection<Subject> subjects, ICollection<Teacher> teachers)
        {
            this.subjects = subjects;
            this.teachers = teachers;
            InitializeComponent();
            SetComboBoxes();
        }
        private void SetComboBoxes()
        {
            cmbSubject.Items.Clear();
            cmbSubject.Items.AddRange(subjects.Select(s => s.Name).ToArray());
            cmbTeacher.Items.Clear();
            cmbTeacher.Items.AddRange(teachers.Select(t => t.ToString()).ToArray());
        }

        public ICollection<Teacher> GetTeachers()
        {
            return teachers;
        }

        public ICollection<Subject> GetSubjects()
        {
            return subjects;
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject _subject = subjects.First(s => s.Name == (string)cmbSubject.SelectedItem);
            txtSubjectName.Text = _subject.Name;
            txtSubjectShortName.Text = _subject.ShortName;
            txtECTS.Text = _subject.ECTS.ToString();
            cmbTeacher.SelectedItem = _subject.Teacher.ToString();
        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher _teacher = teachers.First(t => t.ToString() == (string)cmbTeacher.SelectedItem);
            txtTeacherFirstName.Text = _teacher.FirstName;
            txtTeacherLastName.Text = _teacher.LastName;
            txtEmail.Text = _teacher.Email;
            txtLink.Text = _teacher.Link;
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            if (AnySubjectFieldIsEmptyOrWrong())
            {
                return;
            }
            else
            {
                Subject _subject = subjects.First(s => s.Name == (string)cmbSubject.SelectedItem);
                _subject.Name = txtSubjectName.Text;
                _subject.ShortName = txtSubjectShortName.Text;
                _subject.ECTS = Int32.Parse(txtECTS.Text);

                SetComboBoxes();
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (AnySubjectFieldIsEmptyOrWrong())
            {
                return;
            }
            else
            {
                subjects.Add(new Subject(
                    txtSubjectName.Text
                    , txtSubjectShortName.Text
                    , teachers.First(t => t.ToString()==(string)cmbTeacher.SelectedItem)
                    , Int32.Parse(txtECTS.Text)  
                    ));

                SetComboBoxes();
            }
        }

        private void btnSaveTeacher_Click(object sender, EventArgs e)
        {
            if (AnyTeacherFieldIsEmpty())
            {
                return;
            }
            else
            {
                Teacher _teacher = teachers.First(t => t.ToString() == (string)cmbTeacher.SelectedItem);
                _teacher.FirstName = txtTeacherFirstName.Text;
                _teacher.LastName = txtTeacherLastName.Text;
                _teacher.Email = txtEmail.Text;
                _teacher.Link = txtLink.Text;

                SetComboBoxes();
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (AnyTeacherFieldIsEmpty())
            {
                return;
            }
            else
            {
                teachers.Add(new Teacher(
                txtTeacherFirstName.Text
                , txtTeacherLastName.Text
                , txtEmail.Text
                , txtLink.Text
                ));

                SetComboBoxes();
            }
        }
        
        private bool AnySubjectFieldIsEmptyOrWrong()
        {
            bool _isEmpty = false;
            if (String.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                errSubject.SetError(txtSubjectName, "Pole nie może być puste");
                _isEmpty = true;
            }
            if (String.IsNullOrWhiteSpace(txtSubjectShortName.Text))
            {
                errSubject.SetError(txtSubjectShortName, "Pole nie może być puste");
                _isEmpty = true;
            }
            if (String.IsNullOrWhiteSpace(txtECTS.Text))
            {
                errSubject.SetError(txtECTS, "Pole nie może być puste"); 
                _isEmpty = true;
            }
            if (!Int32.TryParse(txtECTS.Text, out int temp))
            {
                errSubject.SetError(txtECTS, "Pole musi być liczbą całkowitą");
                _isEmpty = true;
            }
            return _isEmpty;
        }

        private bool AnyTeacherFieldIsEmpty()
        {
            bool _isEmpty = false;
            if (String.IsNullOrWhiteSpace(txtTeacherFirstName.Text))
            {
                errSubject.SetError(txtTeacherFirstName, "Pole nie może być puste");
                _isEmpty = true;
            }
            if (String.IsNullOrWhiteSpace(txtTeacherLastName.Text))
            {
                errSubject.SetError(txtTeacherLastName, "Pole nie może być puste");
                _isEmpty = true;
            }
            return _isEmpty;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //TO BE DELETED
            ///
            //
            //
            
            //
            //
            //
            //
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
