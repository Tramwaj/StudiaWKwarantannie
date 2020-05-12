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
            this.olvEvents = new BrightIdeasSoftware.ObjectListView();
            this.olvColSubject = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColDuration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColNotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            ((System.ComponentModel.ISupportInitialize)(this.olvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
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
            this.lvwEvents.Location = new System.Drawing.Point(484, 246);
            this.lvwEvents.Margin = new System.Windows.Forms.Padding(2);
            this.lvwEvents.Name = "lvwEvents";
            this.lvwEvents.Size = new System.Drawing.Size(73, 205);
            this.lvwEvents.TabIndex = 5;
            this.lvwEvents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteEvent.Location = new System.Drawing.Point(291, 246);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteEvent.TabIndex = 1;
            this.btnDeleteEvent.Text = "Usuń";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(9, 383);
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
            this.cklSubjects.Size = new System.Drawing.Size(264, 124);
            this.cklSubjects.TabIndex = 2;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(140, 383);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(113, 71);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Dodaj zadanie";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // btnCancelCalendar
            // 
            this.btnCancelCalendar.Location = new System.Drawing.Point(3, 212);
            this.btnCancelCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCalendar.Name = "btnCancelCalendar";
            this.btnCancelCalendar.Size = new System.Drawing.Size(262, 30);
            this.btnCancelCalendar.TabIndex = 8;
            this.btnCancelCalendar.Text = "Wszystko";
            this.btnCancelCalendar.UseVisualStyleBackColor = true;
            // 
            // olvEvents
            // 
            this.olvEvents.AllColumns.Add(this.olvColSubject);
            this.olvEvents.AllColumns.Add(this.olvColTime);
            this.olvEvents.AllColumns.Add(this.olvColDuration);
            this.olvEvents.AllColumns.Add(this.olvColType);
            this.olvEvents.AllColumns.Add(this.olvColStatus);
            this.olvEvents.AllColumns.Add(this.olvColNotes);
            this.olvEvents.CausesValidation = false;
            this.olvEvents.CellEditUseWholeCell = false;
            this.olvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSubject,
            this.olvColTime,
            this.olvColDuration,
            this.olvColType,
            this.olvColStatus,
            this.olvColNotes});
            this.olvEvents.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvEvents.HideSelection = false;
            this.olvEvents.Location = new System.Drawing.Point(294, 34);
            this.olvEvents.Name = "olvEvents";
            this.olvEvents.Size = new System.Drawing.Size(359, 162);
            this.olvEvents.TabIndex = 9;
            this.olvEvents.UseCompatibleStateImageBehavior = false;
            this.olvEvents.View = System.Windows.Forms.View.Details;
            this.olvEvents.SelectedIndexChanged += new System.EventHandler(this.olvEvents_SelectedIndexChanged);
            // 
            // olvColSubject
            // 
            this.olvColSubject.AspectName = "Subject.Name";
            this.olvColSubject.Text = "Przedmiot";
            // 
            // olvColTime
            // 
            this.olvColTime.AspectName = "Time";
            this.olvColTime.AspectToStringFormat = "{0:HH:mm}";
            this.olvColTime.Text = "Time";
            // 
            // olvColDuration
            // 
            this.olvColDuration.AspectName = "Duration";
            this.olvColDuration.Text = "Duration";
            // 
            // olvColType
            // 
            this.olvColType.AspectName = "Type";
            this.olvColType.Text = "Type";
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
            // objectListView1
            // 
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(456, 246);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(197, 208);
            this.objectListView1.TabIndex = 10;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 476);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.olvEvents);
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
            ((System.ComponentModel.ISupportInitialize)(this.olvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
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
        private BrightIdeasSoftware.ObjectListView olvEvents;
        private BrightIdeasSoftware.OLVColumn olvColSubject;
        private BrightIdeasSoftware.OLVColumn olvColTime;
        private BrightIdeasSoftware.OLVColumn olvColDuration;
        private BrightIdeasSoftware.OLVColumn olvColType;
        private BrightIdeasSoftware.OLVColumn olvColStatus;
        private BrightIdeasSoftware.OLVColumn olvColNotes;
        private BrightIdeasSoftware.ObjectListView objectListView1;
    }
}

