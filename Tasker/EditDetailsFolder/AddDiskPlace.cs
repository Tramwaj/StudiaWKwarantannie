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
    public partial class AddDiskPlace : Form
    {        
        private string _chosenPath;
        private DiskPlace diskPlace;

        public AddDiskPlace()
        {
            InitializeComponent();
        }

        public DiskPlace GetResult()
        {
            return diskPlace;
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog
            {                
                IsFolderPicker = rdoFolder.Checked ? true : false
            };
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                _chosenPath = openFileDialog.FileName;
                lblChosenDiskPlace.Text = _chosenPath;
                btnOk.Enabled = true;                
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Pole nie może być puste");
            }
            else
            {
                diskPlace = new DiskPlace(_chosenPath, txtDescription.Text, rdoIsAFile.Checked);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
