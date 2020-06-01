﻿using System;
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
    public partial class EditDetails : Form
    {
        private Activity _activity;
        private ICollection<Note> _notes;
        private ICollection<string> _links;
        private ICollection<string> _places;

        public EditDetails(Activity activity)
        {               
            InitializeComponent();
            lblSubject.Text = activity.Subject.Name;
            lblTime.Text = activity.Time.ToString();
            lblStatus.Text = TranslateStatus(activity.Status);
            _links = activity.Links;
            _places = activity.PlaceOnDisk;
            _notes = activity.Notes;
            rtxNote.Text = "Treść wybranej notatki";
            FillListViews();
        }        
        public EditDetails(Lesson activity):this((Activity)activity)
        {
            lblType.Text = "Spotkanie";
            lblDuration.Text = activity.Duration.ToString();
        }
        public EditDetails(Job activity) : this((Activity)activity)
        {            
            lblName.Text = activity.Name;
            lblType.Text = "Zadanie";
        }
        private void FillListViews()
        {
            olvNotes.SetObjects(_notes);
            olvLinks.SetObjects(_links);
            olvPlaces.SetObjects(_places);
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
            FillListViews();
        }
    }
}
