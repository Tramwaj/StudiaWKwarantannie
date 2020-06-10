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
        private string _filePath;

        public AddJob(ICollection<Subject> subjects)
        {
            InitializeComponent();
            _subjects = subjects;
            cmbSubject.Items.AddRange(subjects.Select(s => s.ShortName).OrderBy(s => s).ToArray());
            SetComboBoxesToDefault();
        }

        public Job GetResult()
        {
            return job;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime _time = dtpDate.Value.Date;
            _time = _time.AddHours(Convert.ToInt32(cmbStartHour.SelectedItem));
            _time = _time.AddMinutes(Convert.ToInt32(cmbStartMinutes.SelectedItem));
                        
            job = new Job
                (_subjects.Where(s => s.ShortName.Equals(cmbSubject.SelectedItem)).First()
                , _time
                , (TaskType)cmbJobType.SelectedIndex
                , txtName.Text
                , rtxDescription.Text
                , new List<DiskPlace> { new DiskPlace(_filePath, "", false) } //To change (different implementation in form)
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
                _filePath = OpenFolder.FileName;
            }

        }

        //TODO: clean these:       

        private void AddJob_Load(object sender, EventArgs e)
        {

        }
    }
}
