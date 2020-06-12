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
                
                // Take some action on e.Model based on which button (e.ColumnIndex) was clicked

                // ...

                // If something about the object changed, you probably want to refresh the model
                //this.olv.RefreshObject(e.Model);
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
                _activity = new Lesson
                    (
                     _subject
                     , DateTime.Parse(lblTime.Text)
                     , TimeSpan.Parse(lblDuration.Text)
                     , LessonType.Lab//TODO
                     , _diskPlaces
                     , _links
                     , _notes
                    );
            }
            else
            {
                _activity = new Job
                    (
                    _subject
                    , DateTime.Parse(lblTime.Text)
                    , TaskType.LabReport
                    , lblName.Text
                    , lblDescription.Text
                    , _diskPlaces
                    , _links
                    , _notes
                    );
            }
        }



        private void olvPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            string _defaultPath = _diskPlaces.FirstOrDefault().Path;
            using (AddDiskPlace addDiskPlace = new AddDiskPlace(_defaultPath))
            {
                if (addDiskPlace.ShowDialog() == DialogResult.OK)
                {
                    _diskPlaces.Add(addDiskPlace.GetResult());
                }
            }
            RefreshListViews();

        }
    }
}
