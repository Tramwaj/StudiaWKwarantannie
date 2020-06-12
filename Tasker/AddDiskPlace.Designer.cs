namespace Tasker
{
    partial class AddDiskPlace
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFolder = new System.Windows.Forms.RadioButton();
            this.rdoFile = new System.Windows.Forms.RadioButton();
            this.lblChosenDiskPlace = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 63);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(116, 20);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "Nazwa";
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(27, 121);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(146, 58);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(80, 29);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "Wybierz...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFile);
            this.groupBox1.Controls.Add(this.rdoFolder);
            this.groupBox1.Location = new System.Drawing.Point(21, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoFolder
            // 
            this.rdoFolder.AutoSize = true;
            this.rdoFolder.Checked = true;
            this.rdoFolder.Location = new System.Drawing.Point(6, 16);
            this.rdoFolder.Name = "rdoFolder";
            this.rdoFolder.Size = new System.Drawing.Size(54, 17);
            this.rdoFolder.TabIndex = 0;
            this.rdoFolder.TabStop = true;
            this.rdoFolder.Text = "Folder";
            this.rdoFolder.UseVisualStyleBackColor = true;
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Location = new System.Drawing.Point(125, 16);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(42, 17);
            this.rdoFile.TabIndex = 1;
            this.rdoFile.Text = "Plik";
            this.rdoFile.UseVisualStyleBackColor = true;
            // 
            // lblChosenDiskPlace
            // 
            this.lblChosenDiskPlace.AutoSize = true;
            this.lblChosenDiskPlace.Location = new System.Drawing.Point(72, 96);
            this.lblChosenDiskPlace.Name = "lblChosenDiskPlace";
            this.lblChosenDiskPlace.Size = new System.Drawing.Size(0, 13);
            this.lblChosenDiskPlace.TabIndex = 5;
            // 
            // AddDiskPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 174);
            this.Controls.Add(this.lblChosenDiskPlace);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDescription);
            this.Name = "AddDiskPlace";
            this.Text = "AddDiskPlace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFile;
        private System.Windows.Forms.RadioButton rdoFolder;
        private System.Windows.Forms.Label lblChosenDiskPlace;
    }
}