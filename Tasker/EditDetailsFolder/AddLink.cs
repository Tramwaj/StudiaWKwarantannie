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
    public partial class AddLink : Form
    {
        private string _chosenPath;
        private Link link;
        public AddLink()
        {
            InitializeComponent();
        }
        public Link GetResult()
        {
            return link;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (AnyStringIsEmpty())
            {
                return;
            }
            else
            {
                link = new Link(txtPath.Text, rtxDescription.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private bool AnyStringIsEmpty()
        {
            
            errorProvider1.Clear();
            if (String.IsNullOrWhiteSpace(txtPath.Text))
            {
                errorProvider1.SetError(txtPath, "Pole nie może być puste");
            }
            else if (String.IsNullOrWhiteSpace(rtxDescription.Text))
            {
                errorProvider1.SetError(rtxDescription, "Pole nie moż e być puste");
            }
            else 
            {
                return false;
            }
            return true;
        }
    }
}
