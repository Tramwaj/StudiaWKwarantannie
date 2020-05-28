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
    public partial class EditDetails : Form
    {
        private Activity activity;

        public EditDetails()
        {
            InitializeComponent();
        }
        public EditDetails(Activity activity):this()
        {
            TypeSpecificInitialization((dynamic)activity);
        }
        public void TypeSpecificInitialization(Lesson activity)
        {
            lblName.Text = "Lesson";
        }
        public void TypeSpecificInitialization(Job activity)
        {
            lblName.Text = "Job";
        }

        internal Activity getResult()
        {
            return activity;
        }
    }
}
