using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasker.EditDetailsFolder;
using Tasker.Models;

namespace Tasker
{
    public partial class EditDetails : Form
    {
        private Activity _activity;
        private ICollection<Note> _notes;
        private ICollection<Link> _links;
        private ICollection<DiskPlace> _diskPlaces;
        private bool _isLesson;
        private Subject subject;

        private readonly ICollection<Subject> subjects;

        //TODO:
        //true/false
        //dynamic

        public EditDetails(Activity activity, ICollection<Subject> subjects)
        {
            InitializeComponent();
            this.subjects = subjects;

            subject = activity.Subject;
            lblSubject.Text = subject.Name;
            lblTime.Text = activity.Time.ToString();
            lblStatus.Text = TranslateStatus(activity.Status);
            _links = activity.Links;
            _diskPlaces = activity.DiskPlaces;
            _notes = activity.Notes;
            rtxNote.Text = "Treść wybranej notatki";
            FormatListViews();

            if (activity is Lesson l)
            {
                lblType.Text = l.Type.ToString();
                lblDuration.Text = l.Duration.ToString();
                _isLesson = true;
                lblDescription.Visible = false;
                lblName.Text = "Spotkanie";
            }

            if (activity is Job j)
            {
                lblName.Text = j.Name;
                lblType.Text = j.Type.ToString();
                lblDescription.Text = j.Description;
                _isLesson = false;
                SetCmbStatus(activity.Status);
            }
        }

        private void FormatListViews()
        {
            RefreshListViews();
            olvColOpen.IsButton = true;
            olvLinks.UseHyperlinks = true;
            olvPlaces.ButtonClick += delegate (object sender, CellClickEventArgs e)
            {
                DiskPlace _diskPlace = (DiskPlace)e.Model;
                if (_diskPlace.IsFile)
                {
                    Process.Start(_diskPlace.Path);
                }
                else
                {
                    Process.Start("explorer.exe", _diskPlace.Path);
                }
            };
            olvColOpen.AspectToStringConverter = delegate (object x)
            {
                bool IsFile = (bool)x;
                if (IsFile)
                {
                    return "Plik";
                }
                else
                {
                    return "Folder";
                }
            };
        }

        private void RefreshListViews()
        {
            olvNotes.SetObjects(_notes);
            olvLinks.SetObjects(_links);
            olvPlaces.SetObjects(_diskPlaces);
        }

        private string TranslateStatus(Status status)
        {
            switch (status)
            {
                case Status.Finished: return "Skończone";
                case Status.InProgress: return "Rozpoczęte";
                case Status.Scheduled: return "Zaplanowane";
            }
            return "status niedostępny";
        }

        private void SetCmbStatus(Status status)
        {
            cmbStatus.Items.AddRange(new string[] { "Skończone", "Rozpoczęte", "Zaplanowane" });
            cmbStatus.Visible = true;
            cmbStatus.Enabled = true;
            switch (status)
            {
                case Status.Finished:
                    cmbStatus.SelectedIndex = 0;
                    break;
                case Status.InProgress:
                    cmbStatus.SelectedIndex = 1;
                    break;
                case Status.Scheduled:
                    cmbStatus.SelectedIndex = 2;
                    break;
            }
        }

        internal Activity getResult()
        {
            return _activity;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            using (AddNote addNote = new AddNote())
            {
                if (addNote.ShowDialog() == DialogResult.OK)
                {
                    _notes.Add(addNote.GetResult());
                }
            }
            RefreshListViews();
        }
        /// <summary>
        /// Seriously hating this right now?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isLesson)
            {
                LessonType _type;
                Enum.TryParse(lblType.Text, out _type);
                _activity = new Lesson
                    (
                     subject
                     , DateTime.Parse(lblTime.Text)
                     , TimeSpan.Parse(lblDuration.Text)
                     , _type
                     , _diskPlaces
                     , _links
                     , _notes
                    );
            }
            else
            {
                TaskType _type;
                Enum.TryParse(lblType.Text, out _type);
                _activity = new Job
                    (
                    subject
                    , DateTime.Parse(lblTime.Text)
                    , _type
                    , lblName.Text
                    , lblDescription.Text
                    , _diskPlaces
                    , _links
                    , _notes
                    , cmbStatus.SelectedItem.ToString()
                    );
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            using (AddDiskPlace addDiskPlace = new AddDiskPlace())
            {
                if (addDiskPlace.ShowDialog() == DialogResult.OK)
                {
                    _diskPlaces.Add(addDiskPlace.GetResult());
                }
            }
            RefreshListViews();

        }

        private void btnRemoveDiskPlace_Click(object sender, EventArgs e)
        {
            IEnumerable<DiskPlace> _diskPlacesToDelete = olvPlaces.SelectedObjects.OfType<DiskPlace>();
            DialogResult deleteConfirmed = MessageBox.Show(
                $"Czy chcesz usunąć {_diskPlacesToDelete.Count()} zapisów?", "Usuń", MessageBoxButtons.OKCancel);
            if (deleteConfirmed == DialogResult.OK)
            {
                foreach (var _diskplace in _diskPlacesToDelete)
                {
                    _diskPlaces.Remove(_diskplace);
                }
                RefreshListViews();
            }
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            using (AddLink addLink = new AddLink())
            {
                if (addLink.ShowDialog() == DialogResult.OK)
                {
                    _links.Add(addLink.GetResult());
                }
            }
            RefreshListViews();
        }

        private void olvNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note _note = ((Note)olvNotes.SelectedObject);
            if (_note is null)
            {
                return;
            }
            else
            {
                rtxNote.Text = _note.Content;
            }
        }

        private void olvPlaces_SelectedIndexChanged(object sender, EventArgs e) //TO BE REMOVED
        {

            //TO BE REMOVED
            //TO BE REMOVED
            //TO BE REMOVED
            //TO BE REMOVED

        }

        private void lblSubjectDoubleClick(object sender, EventArgs e)
        {
            using (ChangeSubject changeSubject = new ChangeSubject(
                subjects.Select(s => s.Name).ToArray(),
                subject.Name
                ))
            {
                if (changeSubject.ShowDialog() == DialogResult.OK)
                {
                    string subjectName = changeSubject.GetResult();
                    subject = subjects.First(s => s.Name.Equals(subjectName));
                    lblSubject.Text = subject.Name;
                }

            }
        }
        private void lblName_DoubleClick(object sender, EventArgs e)
        {
            var label = (Label)sender;
            using (EditProperty editProperty = new EditProperty(label.Text))
            {
                if (editProperty.ShowDialog() == DialogResult.OK)
                {
                    label.Text = editProperty.GetResult();
                }
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            var label = (Label)sender;
            using (EditTime editTime = new EditTime(label.Text))
            {
                if (editTime.ShowDialog() == DialogResult.OK)
                {
                    label.Text = editTime.GetResult();
                }
            }
        }
    }
}
