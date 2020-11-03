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
    public partial class EditProperty : Form
    {
        public EditProperty(string text)
        {
            InitializeComponent();
            textBox.Text = text;
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
            return textBox.Text;
        }
    }
}
