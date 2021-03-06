﻿namespace Tasker
{
    partial class AddJob
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
            this.cmbStartMinutes = new System.Windows.Forms.ComboBox();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbJobType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtDiskPlace = new System.Windows.Forms.TextBox();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStartMinutes
            // 
            this.cmbStartMinutes.FormattingEnabled = true;
            this.cmbStartMinutes.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbStartMinutes.Location = new System.Drawing.Point(239, 110);
            this.cmbStartMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStartMinutes.Name = "cmbStartMinutes";
            this.cmbStartMinutes.Size = new System.Drawing.Size(47, 24);
            this.cmbStartMinutes.TabIndex = 39;
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            this.cmbStartHour.Location = new System.Drawing.Point(157, 110);
            this.cmbStartHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(45, 24);
            this.cmbStartHour.TabIndex = 37;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(157, 23);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(160, 24);
            this.cmbSubject.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Przedmiot:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "h";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 538);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 50);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(53, 538);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 50);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbJobType
            // 
            this.cmbJobType.FormattingEnabled = true;
            this.cmbJobType.Items.AddRange(new object[] {
            "Projekt",
            "Sprawozdanie",
            "Inny"});
            this.cmbJobType.Location = new System.Drawing.Point(157, 199);
            this.cmbJobType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJobType.Name = "cmbJobType";
            this.cmbJobType.Size = new System.Drawing.Size(160, 24);
            this.cmbJobType.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Rodzaj zajęć:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Godzina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Deadline:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(157, 60);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 158);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 22);
            this.txtName.TabIndex = 40;
            this.txtName.Text = "Nazwa zadania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Opis:";
            // 
            // rtxDescription
            // 
            this.rtxDescription.Location = new System.Drawing.Point(157, 252);
            this.rtxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.Size = new System.Drawing.Size(265, 107);
            this.rtxDescription.TabIndex = 42;
            this.rtxDescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Linki:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 383);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Miejsce na dysku:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(287, 377);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(137, 28);
            this.btnAddFile.TabIndex = 46;
            this.btnAddFile.Text = "Wybierz";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtDiskPlace
            // 
            this.txtDiskPlace.Location = new System.Drawing.Point(132, 380);
            this.txtDiskPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiskPlace.Name = "txtDiskPlace";
            this.txtDiskPlace.Size = new System.Drawing.Size(132, 22);
            this.txtDiskPlace.TabIndex = 47;
            this.txtDiskPlace.Text = "Folder domyślny";
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.HideSelection = false;
            this.fastObjectListView1.Location = new System.Drawing.Point(157, 422);
            this.fastObjectListView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(265, 82);
            this.fastObjectListView1.TabIndex = 48;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 623);
            this.Controls.Add(this.fastObjectListView1);
            this.Controls.Add(this.txtDiskPlace);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtxDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbStartMinutes);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbJobType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddJob";
            this.Text = "AddJob";
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStartMinutes;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbJobType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtDiskPlace;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}