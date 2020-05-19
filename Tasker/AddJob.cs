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

            //development comment: Subject subject, DateTime time, TaskType type, string name, string description, string placeOnDisk, ICollection<string> links): base(subject, time)
            job = new Job
                (_subjects.Where(s => s.ShortName.Equals(cmbSubject.SelectedItem)).First()
                , _time
                , (TaskType)cmbJobType.SelectedIndex
                , txtName.Text
                , rtxDescription.Text
                , _filePath
                , null); //TODO: Linki
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

            _filePath = openFileDialog1.FileName;
        }

        //TODO: clean these:
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddJob_Load(object sender, EventArgs e)
        {

        }        
    }
}
