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
    public partial class EditTime : Form
    {
        public EditTime(string text)
        {
            InitializeComponent();
            var _date = DateTime.Parse(text);
            dtpDate.Value = _date.Date;
            cmbHour.SelectedItem = _date.Hour.ToString();
            cmbMinutes.SelectedItem = _date.Minute.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string GetResult()
        {
            
            DateTime _time = dtpDate.Value.Date;
            _time = _time.AddHours(Convert.ToInt32(cmbHour.SelectedItem));
            _time = _time.AddMinutes(Convert.ToInt32(cmbMinutes.SelectedItem));
            return _time.ToString(); ;
        }
    }
}
