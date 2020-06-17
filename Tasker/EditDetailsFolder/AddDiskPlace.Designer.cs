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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoIsAFile = new System.Windows.Forms.RadioButton();
            this.rdoFolder = new System.Windows.Forms.RadioButton();
            this.lblChosenDiskPlace = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 78);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(153, 22);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "Nazwa";
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(36, 149);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 37);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 149);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(195, 71);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(107, 36);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "Wybierz...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoIsAFile);
            this.groupBox1.Controls.Add(this.rdoFolder);
            this.groupBox1.Location = new System.Drawing.Point(28, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(327, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoFile
            // 
            this.rdoIsAFile.AutoSize = true;
            this.rdoIsAFile.Location = new System.Drawing.Point(167, 20);
            this.rdoIsAFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoIsAFile.Name = "rdoFile";
            this.rdoIsAFile.Size = new System.Drawing.Size(51, 21);
            this.rdoIsAFile.TabIndex = 1;
            this.rdoIsAFile.Text = "Plik";
            this.rdoIsAFile.UseVisualStyleBackColor = true;
            // 
            // rdoFolder
            // 
            this.rdoFolder.AutoSize = true;
            this.rdoFolder.Checked = true;
            this.rdoFolder.Location = new System.Drawing.Point(8, 20);
            this.rdoFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoFolder.Name = "rdoFolder";
            this.rdoFolder.Size = new System.Drawing.Size(69, 21);
            this.rdoFolder.TabIndex = 0;
            this.rdoFolder.TabStop = true;
            this.rdoFolder.Text = "Folder";
            this.rdoFolder.UseVisualStyleBackColor = true;
            // 
            // lblChosenDiskPlace
            // 
            this.lblChosenDiskPlace.AutoSize = true;
            this.lblChosenDiskPlace.Location = new System.Drawing.Point(96, 118);
            this.lblChosenDiskPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChosenDiskPlace.Name = "lblChosenDiskPlace";
            this.lblChosenDiskPlace.Size = new System.Drawing.Size(0, 17);
            this.lblChosenDiskPlace.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddDiskPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 214);
            this.Controls.Add(this.lblChosenDiskPlace);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDescription);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDiskPlace";
            this.Text = "AddDiskPlace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.RadioButton rdoIsAFile;
        private System.Windows.Forms.RadioButton rdoFolder;
        private System.Windows.Forms.Label lblChosenDiskPlace;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}