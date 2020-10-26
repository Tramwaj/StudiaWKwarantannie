namespace Tasker
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
            this.olvActivities = new BrightIdeasSoftware.DataListView();
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
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.btnLoadSelected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoShowJobs = new System.Windows.Forms.RadioButton();
            this.rdoShowLessons = new System.Windows.Forms.RadioButton();
            this.rdoShowAll = new System.Windows.Forms.RadioButton();
            this.btnCopyActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvActivities)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(3, 34);
            this.calendar.Margin = new System.Windows.Forms.Padding(7);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lvwEvents
            // 
            this.lvwEvents.HideSelection = false;
            this.lvwEvents.Location = new System.Drawing.Point(291, 494);
            this.lvwEvents.Margin = new System.Windows.Forms.Padding(2);
            this.lvwEvents.Name = "lvwEvents";
            this.lvwEvents.Size = new System.Drawing.Size(73, 30);
            this.lvwEvents.TabIndex = 5;
            this.lvwEvents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stan:";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteEvent.Location = new System.Drawing.Point(707, 329);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(94, 31);
            this.btnDeleteEvent.TabIndex = 1;
            this.btnDeleteEvent.Text = "Usuń";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(9, 392);
            this.btnAddLesson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(106, 71);
            this.btnAddLesson.TabIndex = 0;
            this.btnAddLesson.Text = "Dodaj spotkanie";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // cklSubjects
            // 
            this.cklSubjects.FormattingEnabled = true;
            this.cklSubjects.Location = new System.Drawing.Point(3, 246);
            this.cklSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.cklSubjects.Name = "cklSubjects";
            this.cklSubjects.Size = new System.Drawing.Size(191, 109);
            this.cklSubjects.TabIndex = 2;
            this.cklSubjects.SelectedIndexChanged += new System.EventHandler(this.cklSubjects_SelectedIndexChanged);
            this.cklSubjects.SelectedValueChanged += new System.EventHandler(this.cklSubjects_SelectedValueChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(140, 392);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(113, 71);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Dodaj zadanie";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // btnCancelCalendar
            // 
            this.btnCancelCalendar.Location = new System.Drawing.Point(3, 203);
            this.btnCancelCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCalendar.Name = "btnCancelCalendar";
            this.btnCancelCalendar.Size = new System.Drawing.Size(262, 30);
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
            this.olvNotes.Location = new System.Drawing.Point(502, 375);
            this.olvNotes.Name = "olvNotes";
            this.olvNotes.Size = new System.Drawing.Size(266, 157);
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
            // olvActivities
            // 
            this.olvActivities.AllColumns.Add(this.olvColDate);
            this.olvActivities.AllColumns.Add(this.olvTimeOfDay);
            this.olvActivities.AllColumns.Add(this.olvColSubject);
            this.olvActivities.AllColumns.Add(this.olvColType);
            this.olvActivities.AllColumns.Add(this.olvColStatus);
            this.olvActivities.AllColumns.Add(this.olvColNotes);
            this.olvActivities.AllColumns.Add(this.olvColName);
            this.olvActivities.CellEditUseWholeCell = false;
            this.olvActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColDate,
            this.olvTimeOfDay,
            this.olvColSubject,
            this.olvColType,
            this.olvColStatus,
            this.olvColNotes,
            this.olvColName});
            this.olvActivities.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvActivities.DataSource = null;
            this.olvActivities.FullRowSelect = true;
            this.olvActivities.HideSelection = false;
            this.olvActivities.Location = new System.Drawing.Point(291, 34);
            this.olvActivities.Margin = new System.Windows.Forms.Padding(2);
            this.olvActivities.Name = "olvActivities";
            this.olvActivities.SelectAllOnControlA = false;
            this.olvActivities.Size = new System.Drawing.Size(512, 284);
            this.olvActivities.TabIndex = 11;
            this.olvActivities.UseCompatibleStateImageBehavior = false;
            this.olvActivities.View = System.Windows.Forms.View.Details;
            this.olvActivities.SelectedIndexChanged += new System.EventHandler(this.dlvActivities_SelectedIndexChanged);
            this.olvActivities.DoubleClick += new System.EventHandler(this.dlvActivities_DoubleClick);
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
            this.olvTimeOfDay.Sortable = false;
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
            this.olvColType.Sortable = false;
            this.olvColType.Text = "Rodzaj";
            // 
            // olvColStatus
            // 
            this.olvColStatus.AspectName = "Status";
            this.olvColStatus.Sortable = false;
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
            this.olvColName.Width = 120;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(291, 329);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(94, 31);
            this.btnDetails.TabIndex = 12;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 485);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 39);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(9, 485);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 39);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(773, 375);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddNote.Size = new System.Drawing.Size(29, 157);
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
            this.cmbState.Location = new System.Drawing.Point(342, 11);
            this.cmbState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(92, 21);
            this.cmbState.TabIndex = 16;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnEditSubjects
            // 
            this.btnEditSubjects.Location = new System.Drawing.Point(208, 247);
            this.btnEditSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSubjects.Name = "btnEditSubjects";
            this.btnEditSubjects.Size = new System.Drawing.Size(56, 114);
            this.btnEditSubjects.TabIndex = 17;
            this.btnEditSubjects.Text = "Edytuj przedmioty";
            this.btnEditSubjects.UseVisualStyleBackColor = true;
            this.btnEditSubjects.UseWaitCursor = true;
            this.btnEditSubjects.Click += new System.EventHandler(this.btnEditSubjects_Click);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Location = new System.Drawing.Point(389, 329);
            this.btnSaveSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(94, 31);
            this.btnSaveSelected.TabIndex = 18;
            this.btnSaveSelected.Text = "Zapisz wybrane";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // btnLoadSelected
            // 
            this.btnLoadSelected.Location = new System.Drawing.Point(487, 329);
            this.btnLoadSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadSelected.Name = "btnLoadSelected";
            this.btnLoadSelected.Size = new System.Drawing.Size(104, 31);
            this.btnLoadSelected.TabIndex = 19;
            this.btnLoadSelected.Text = "Wczytaj wybrane";
            this.btnLoadSelected.UseVisualStyleBackColor = true;
            this.btnLoadSelected.Click += new System.EventHandler(this.btnLoadSelected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoShowJobs);
            this.groupBox1.Controls.Add(this.rdoShowLessons);
            this.groupBox1.Controls.Add(this.rdoShowAll);
            this.groupBox1.Location = new System.Drawing.Point(447, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 26);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // rdoShowJobs
            // 
            this.rdoShowJobs.AutoSize = true;
            this.rdoShowJobs.Location = new System.Drawing.Point(207, 9);
            this.rdoShowJobs.Name = "rdoShowJobs";
            this.rdoShowJobs.Size = new System.Drawing.Size(64, 17);
            this.rdoShowJobs.TabIndex = 2;
            this.rdoShowJobs.TabStop = true;
            this.rdoShowJobs.Text = "Zadania";
            this.rdoShowJobs.UseVisualStyleBackColor = true;
            this.rdoShowJobs.CheckedChanged += new System.EventHandler(this.rdoShowJobs_CheckedChanged);
            // 
            // rdoShowLessons
            // 
            this.rdoShowLessons.AutoSize = true;
            this.rdoShowLessons.Location = new System.Drawing.Point(116, 9);
            this.rdoShowLessons.Name = "rdoShowLessons";
            this.rdoShowLessons.Size = new System.Drawing.Size(60, 17);
            this.rdoShowLessons.TabIndex = 1;
            this.rdoShowLessons.TabStop = true;
            this.rdoShowLessons.Text = "Zajęcia";
            this.rdoShowLessons.UseVisualStyleBackColor = true;
            this.rdoShowLessons.CheckedChanged += new System.EventHandler(this.rdoShowLessons_CheckedChanged);
            // 
            // rdoShowAll
            // 
            this.rdoShowAll.AutoSize = true;
            this.rdoShowAll.Location = new System.Drawing.Point(18, 9);
            this.rdoShowAll.Name = "rdoShowAll";
            this.rdoShowAll.Size = new System.Drawing.Size(71, 17);
            this.rdoShowAll.TabIndex = 0;
            this.rdoShowAll.TabStop = true;
            this.rdoShowAll.Text = "Wszystko";
            this.rdoShowAll.UseVisualStyleBackColor = true;
            this.rdoShowAll.CheckedChanged += new System.EventHandler(this.rdoShowAll_CheckedChanged);
            // 
            // btnCopyActivity
            // 
            this.btnCopyActivity.Location = new System.Drawing.Point(596, 329);
            this.btnCopyActivity.Name = "btnCopyActivity";
            this.btnCopyActivity.Size = new System.Drawing.Size(94, 31);
            this.btnCopyActivity.TabIndex = 21;
            this.btnCopyActivity.Text = "Kopiuj";
            this.btnCopyActivity.UseVisualStyleBackColor = true;
            this.btnCopyActivity.Click += new System.EventHandler(this.btnCopyActivity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 544);
            this.Controls.Add(this.btnCopyActivity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadSelected);
            this.Controls.Add(this.btnSaveSelected);
            this.Controls.Add(this.btnEditSubjects);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.olvActivities);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.olvNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvActivities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private BrightIdeasSoftware.DataListView olvActivities;
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
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.Button btnLoadSelected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoShowJobs;
        private System.Windows.Forms.RadioButton rdoShowLessons;
        private System.Windows.Forms.RadioButton rdoShowAll;
        private System.Windows.Forms.Button btnCopyActivity;
    }
}

