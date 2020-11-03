namespace Tasker.EditDetailsFolder
{
    partial class EditTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbMinutes = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 65);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(261, 26);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 31);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Zapisz";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.FormattingEnabled = true;
            this.cmbMinutes.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45"});
            this.cmbMinutes.Location = new System.Drawing.Point(141, 71);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(94, 21);
            this.cmbMinutes.TabIndex = 6;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHour.Location = new System.Drawing.Point(35, 71);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(94, 21);
            this.cmbHour.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(35, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 8;
            // 
            // EditTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 137);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.cmbMinutes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "EditTime";
            this.Text = "EditTime";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbMinutes;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}