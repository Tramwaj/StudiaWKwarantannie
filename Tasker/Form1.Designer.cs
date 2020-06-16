﻿namespace Tasker
{
    partial class Form1
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.lvwEvents = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.cklSubjects = new System.Windows.Forms.CheckedListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelCalendar = new System.Windows.Forms.Button();
            this.olvNotes = new BrightIdeasSoftware.ObjectListView();
            this.olvColNoteName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColNoteDateCreated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dlvActivities = new BrightIdeasSoftware.DataListView();
            this.olvColDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvTimeOfDay = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSubject = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColNotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.btnEditSubjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(4, 42);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lvwEvents
            // 
            this.lvwEvents.HideSelection = false;
            this.lvwEvents.Location = new System.Drawing.Point(388, 608);
            this.lvwEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwEvents.Name = "lvwEvents";
            this.lvwEvents.Size = new System.Drawing.Size(96, 36);
            this.lvwEvents.TabIndex = 5;
            this.lvwEvents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stan:";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteEvent.Location = new System.Drawing.Point(945, 405);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(125, 38);
            this.btnDeleteEvent.TabIndex = 1;
            this.btnDeleteEvent.Text = "Usuń";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(12, 482);
            this.btnAddLesson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(141, 87);
            this.btnAddLesson.TabIndex = 0;
            this.btnAddLesson.Text = "Dodaj spotkanie";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // cklSubjects
            // 
            this.cklSubjects.FormattingEnabled = true;
            this.cklSubjects.Location = new System.Drawing.Point(4, 303);
            this.cklSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cklSubjects.Name = "cklSubjects";
            this.cklSubjects.Size = new System.Drawing.Size(253, 140);
            this.cklSubjects.TabIndex = 2;
            this.cklSubjects.SelectedIndexChanged += new System.EventHandler(this.cklSubjects_SelectedIndexChanged);
            this.cklSubjects.SelectedValueChanged += new System.EventHandler(this.cklSubjects_SelectedValueChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(187, 482);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(151, 87);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Dodaj zadanie";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // btnCancelCalendar
            // 
            this.btnCancelCalendar.Location = new System.Drawing.Point(4, 250);
            this.btnCancelCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelCalendar.Name = "btnCancelCalendar";
            this.btnCancelCalendar.Size = new System.Drawing.Size(349, 37);
            this.btnCancelCalendar.TabIndex = 8;
            this.btnCancelCalendar.Text = "Wszystko";
            this.btnCancelCalendar.UseVisualStyleBackColor = true;
            this.btnCancelCalendar.Click += new System.EventHandler(this.btnCancelCalendar_Click);
            // 
            // olvNotes
            // 
            this.olvNotes.AllColumns.Add(this.olvColNoteName);
            this.olvNotes.AllColumns.Add(this.olvColNoteDateCreated);
            this.olvNotes.CellEditUseWholeCell = false;
            this.olvNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColNoteName,
            this.olvColNoteDateCreated});
            this.olvNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvNotes.HideSelection = false;
            this.olvNotes.Location = new System.Drawing.Point(669, 462);
            this.olvNotes.Margin = new System.Windows.Forms.Padding(4);
            this.olvNotes.Name = "olvNotes";
            this.olvNotes.Size = new System.Drawing.Size(353, 192);
            this.olvNotes.TabIndex = 10;
            this.olvNotes.UseCompatibleStateImageBehavior = false;
            this.olvNotes.View = System.Windows.Forms.View.Details;
            // 
            // olvColNoteName
            // 
            this.olvColNoteName.AspectName = "Name";
            this.olvColNoteName.Text = "Nazwa";
            this.olvColNoteName.Width = 160;
            // 
            // olvColNoteDateCreated
            // 
            this.olvColNoteDateCreated.AspectName = "TimeCreated";
            this.olvColNoteDateCreated.AspectToStringFormat = "{0:dd/MM/yyyy}";
            this.olvColNoteDateCreated.Text = "Data utworzenia";
            this.olvColNoteDateCreated.Width = 128;
            // 
            // dlvActivities
            // 
            this.dlvActivities.AllColumns.Add(this.olvColDate);
            this.dlvActivities.AllColumns.Add(this.olvTimeOfDay);
            this.dlvActivities.AllColumns.Add(this.olvColSubject);
            this.dlvActivities.AllColumns.Add(this.olvColType);
            this.dlvActivities.AllColumns.Add(this.olvColStatus);
            this.dlvActivities.AllColumns.Add(this.olvColNotes);
            this.dlvActivities.AllColumns.Add(this.olvColName);
            this.dlvActivities.CellEditUseWholeCell = false;
            this.dlvActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColDate,
            this.olvTimeOfDay,
            this.olvColSubject,
            this.olvColType,
            this.olvColStatus,
            this.olvColNotes,
            this.olvColName});
            this.dlvActivities.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvActivities.DataSource = null;
            this.dlvActivities.FullRowSelect = true;
            this.dlvActivities.HideSelection = false;
            this.dlvActivities.Location = new System.Drawing.Point(388, 42);
            this.dlvActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dlvActivities.Name = "dlvActivities";
            this.dlvActivities.SelectAllOnControlA = false;
            this.dlvActivities.Size = new System.Drawing.Size(681, 349);
            this.dlvActivities.TabIndex = 11;
            this.dlvActivities.UseCompatibleStateImageBehavior = false;
            this.dlvActivities.View = System.Windows.Forms.View.Details;
            this.dlvActivities.SelectedIndexChanged += new System.EventHandler(this.dlvActivities_SelectedIndexChanged);
            // 
            // olvColDate
            // 
            this.olvColDate.AspectName = "Time";
            this.olvColDate.AspectToStringFormat = "{0:dd/MM}";
            this.olvColDate.Text = "Data";
            // 
            // olvTimeOfDay
            // 
            this.olvTimeOfDay.AspectName = "Time";
            this.olvTimeOfDay.AspectToStringFormat = "{0:HH:mm}";
            this.olvTimeOfDay.Text = "Godzina";
            // 
            // olvColSubject
            // 
            this.olvColSubject.AspectName = "Subject.ShortName";
            this.olvColSubject.Text = "Przedmiot";
            // 
            // olvColType
            // 
            this.olvColType.AspectName = "Type";
            this.olvColType.Text = "Rodzaj";
            // 
            // olvColStatus
            // 
            this.olvColStatus.AspectName = "Status";
            this.olvColStatus.Text = "Status";
            // 
            // olvColNotes
            // 
            this.olvColNotes.AspectName = "Notes.Count";
            this.olvColNotes.Text = "Notatki";
            // 
            // olvColName
            // 
            this.olvColName.AspectName = "Name";
            this.olvColName.Text = "Nazwa";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(388, 405);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(125, 38);
            this.btnDetails.TabIndex = 12;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(187, 597);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 48);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 597);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(141, 48);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(1031, 462);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddNote.Size = new System.Drawing.Size(39, 193);
            this.btnAddNote.TabIndex = 15;
            this.btnAddNote.Text = "D O D A   J  ";
            this.btnAddNote.UseVisualStyleBackColor = true;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Wszystkie",
            "Aktywne",
            "Ukończone"});
            this.cmbState.Location = new System.Drawing.Point(456, 14);
            this.cmbState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 24);
            this.cmbState.TabIndex = 16;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnEditSubjects
            // 
            this.btnEditSubjects.Location = new System.Drawing.Point(278, 304);
            this.btnEditSubjects.Name = "btnEditSubjects";
            this.btnEditSubjects.Size = new System.Drawing.Size(75, 140);
            this.btnEditSubjects.TabIndex = 17;
            this.btnEditSubjects.Text = "Edytuj przedmioty";
            this.btnEditSubjects.UseVisualStyleBackColor = true;
            this.btnEditSubjects.UseWaitCursor = true;
            this.btnEditSubjects.Click += new System.EventHandler(this.btnEditSubjects_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 670);
            this.Controls.Add(this.btnEditSubjects);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dlvActivities);
            this.Controls.Add(this.olvNotes);
            this.Controls.Add(this.btnCancelCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwEvents);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.cklSubjects);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.calendar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.olvNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.CheckedListBox cklSubjects;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwEvents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelCalendar;
        private BrightIdeasSoftware.ObjectListView olvNotes;
        private BrightIdeasSoftware.DataListView dlvActivities;
        private BrightIdeasSoftware.OLVColumn olvColSubject;
        private BrightIdeasSoftware.OLVColumn olvColTime;
        private BrightIdeasSoftware.OLVColumn olvColType;
        private BrightIdeasSoftware.OLVColumn olvColStatus;
        private BrightIdeasSoftware.OLVColumn olvColNotes;
        private System.Windows.Forms.Button btnDetails;
        private BrightIdeasSoftware.OLVColumn olvColName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private BrightIdeasSoftware.OLVColumn olvColDate;
        private BrightIdeasSoftware.OLVColumn olvTimeOfDay;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.ComboBox cmbState;
        private BrightIdeasSoftware.OLVColumn olvColNoteName;
        private BrightIdeasSoftware.OLVColumn olvColNoteDateCreated;
        private System.Windows.Forms.Button btnEditSubjects;
    }
}

