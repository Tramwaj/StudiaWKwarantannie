using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasker.EditDetailsFolder
{
    public partial class ChangeSubject : Form
    {
        private string subjectName;
        public ChangeSubject(string[] subjects, string subject)
        {
            InitializeComponent();
            cmbSubjects.Items.AddRange(subjects);
            cmbSubjects.SelectedItem = subject;
        }


        private void OkClick(object sender, EventArgs e)
        {
            subjectName = cmbSubjects.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public string GetResult()
        {            
            return subjectName;
        }
    }
}
