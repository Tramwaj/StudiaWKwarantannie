using Microsoft.WindowsAPICodePack.Dialogs;
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
    public partial class AddJob : Form
    {
        private Job job;
        private ICollection<Subject> _subjects;
        private List<DiskPlace> _diskPlaces;

        public AddJob(ICollection<Subject> subjects)
        {
            InitializeComponent();
            _subjects = subjects;
            cmbSubject.Items.AddRange(subjects.Select(s => s.ShortName).OrderBy(s => s).ToArray());
            SetComboBoxesToDefault();
            _diskPlaces = new List<DiskPlace>();
        }

        public AddJob(ICollection<Subject> subjects, Job copiedJob) : this(subjects)
        {
            cmbSubject.SelectedItem = copiedJob.Subject.ShortName;
            dtpDate.Value = copiedJob.Time.Date;
            cmbJobType.SelectedIndex = (int)copiedJob.Type;
            txtName.Text = copiedJob.Name;
            rtxDescription.Text = copiedJob.Description;
            cmbStartHour.SelectedItem = copiedJob.Time.Hour.ToString();
            cmbStartMinutes.SelectedItem = copiedJob.Time.Minute.ToString();
        }

        public Job GetResult()
        {
            return job;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Pole nie może być puste");
            }

            DateTime _time = dtpDate.Value.Date;
            _time = _time.AddHours(Convert.ToInt32(cmbStartHour.SelectedItem));
            _time = _time.AddMinutes(Convert.ToInt32(cmbStartMinutes.SelectedItem));

            job = new Job
                (_subjects.Where(s => s.ShortName.Equals(cmbSubject.SelectedItem)).First()
                , _time
                , (TaskType)cmbJobType.SelectedIndex
                , txtName.Text
                , rtxDescription.Text
                , _diskPlaces
                , new List<Link>() //TODO: Links , notes
                , new List<Note>());
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
            cmbStartHour.SelectedIndex = 0;
            cmbStartMinutes.SelectedIndex = 0;
            cmbSubject.SelectedIndex = 0;
            cmbJobType.SelectedIndex = 0;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog OpenFolder = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true
            };
            if (OpenFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                _diskPlaces.Add(new DiskPlace(
                    OpenFolder.FileName
                    , txtDiskPlace.Text,
                    false));
                MessageBox.Show("Dodano folder");
            }

        }

        //TODO: clean these:       

        private void AddJob_Load(object sender, EventArgs e)
        {

        }
    }
}
