using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private Subject _subject;

        public EditDetails(Activity activity)
        {
            InitializeComponent();
            _subject = activity.Subject;
            lblSubject.Text = _subject.Name;
            lblTime.Text = activity.Time.ToString();
            lblStatus.Text = TranslateStatus(activity.Status);
            _links = activity.Links;
            _diskPlaces = activity.DiskPlaces;
            _notes = activity.Notes;
            rtxNote.Text = "Treść wybranej notatki";
            FormatListViews();
        }

        public EditDetails(Lesson activity) : this((Activity)activity)
        {
            lblType.Text = activity.Type.ToString();
            lblDuration.Text = activity.Duration.ToString();
            _isLesson = true;
            lblDescription.Visible = false;
        }

        public EditDetails(Job activity) : this((Activity)activity)
        {
            lblName.Text = activity.Name;
            lblType.Text = activity.Type.ToString();
            lblDescription.Text = activity.Description;
            _isLesson = false;
        }

        private void FormatListViews()
        {
            RefreshListViews();   
            olvColOpen.IsButton = true;
            olvLinks.UseHyperlinks = true;
            olvPlaces.ButtonClick += delegate (object sender, CellClickEventArgs e) {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isLesson)
            {
                LessonType _type;
                Enum.TryParse(lblType.Text, out _type);
                _activity = new Lesson
                    (
                     _subject
                     , DateTime.Parse(lblTime.Text)
                     , TimeSpan.Parse(lblDuration.Text)
                     , _type
                     , _diskPlaces
                     , _links
                     , _notes
                    ) ;
            }
            else
            {
                TaskType _type;
                Enum.TryParse(lblType.Text, out _type);
                _activity = new Job
                    (
                    _subject
                    , DateTime.Parse(lblTime.Text)
                    , _type
                    , lblName.Text
                    , lblDescription.Text
                    , _diskPlaces
                    , _links
                    , _notes
                    ) ;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void olvPlaces_SelectedIndexChanged(object sender, EventArgs e) //TO BE REMOVED
        {

            //TO BE REMOVED
            //TO BE REMOVED
            //TO BE REMOVED
            //TO BE REMOVED

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
    }
}
