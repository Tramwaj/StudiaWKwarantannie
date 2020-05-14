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
            this.components = new System.ComponentModel.Container();
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
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.dlvActivities = new BrightIdeasSoftware.DataListView();
            this.olvColTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSubject = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColNotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
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
            this.lvwEvents.Location = new System.Drawing.Point(645, 303);
            this.lvwEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwEvents.Name = "lvwEvents";
            this.lvwEvents.Size = new System.Drawing.Size(96, 251);
            this.lvwEvents.TabIndex = 5;
            this.lvwEvents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteEvent.Location = new System.Drawing.Point(388, 303);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEvent.TabIndex = 1;
            this.btnDeleteEvent.Text = "Usuń";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(12, 471);
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
            this.cklSubjects.Size = new System.Drawing.Size(351, 140);
            this.cklSubjects.TabIndex = 2;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(187, 471);
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
            this.label3.Location = new System.Drawing.Point(388, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // btnCancelCalendar
            // 
            this.btnCancelCalendar.Location = new System.Drawing.Point(4, 261);
            this.btnCancelCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelCalendar.Name = "btnCancelCalendar";
            this.btnCancelCalendar.Size = new System.Drawing.Size(349, 37);
            this.btnCancelCalendar.TabIndex = 8;
            this.btnCancelCalendar.Text = "Wszystko";
            this.btnCancelCalendar.UseVisualStyleBackColor = true;
            // 
            // objectListView1
            // 
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(608, 303);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(4);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(305, 255);
            this.objectListView1.TabIndex = 10;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // dlvActivities
            // 
            this.dlvActivities.AllColumns.Add(this.olvColTime);
            this.dlvActivities.AllColumns.Add(this.olvColSubject);
            this.dlvActivities.AllColumns.Add(this.olvColType);
            this.dlvActivities.AllColumns.Add(this.olvColStatus);
            this.dlvActivities.AllColumns.Add(this.olvColNotes);
            this.dlvActivities.CellEditUseWholeCell = false;
            this.dlvActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTime,
            this.olvColSubject,
            this.olvColType,
            this.olvColStatus,
            this.olvColNotes});
            this.dlvActivities.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvActivities.HideSelection = false;
            this.dlvActivities.Location = new System.Drawing.Point(388, 42);
            this.dlvActivities.Name = "dlvActivities";
            this.dlvActivities.Size = new System.Drawing.Size(525, 207);
            this.dlvActivities.TabIndex = 11;
            this.dlvActivities.UseCompatibleStateImageBehavior = false;
            this.dlvActivities.View = System.Windows.Forms.View.Details;
            // 
            // olvColTime
            // 
            this.olvColTime.AspectName = "Time";
            this.olvColTime.AspectToStringFormat = "{0:HH:mm}";
            this.olvColTime.Text = "Czas";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 586);
            this.Controls.Add(this.dlvActivities);
            this.Controls.Add(this.objectListView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
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
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.DataListView dlvActivities;
        private BrightIdeasSoftware.OLVColumn olvColSubject;
        private BrightIdeasSoftware.OLVColumn olvColTime;
        private BrightIdeasSoftware.OLVColumn olvColType;
        private BrightIdeasSoftware.OLVColumn olvColStatus;
        private BrightIdeasSoftware.OLVColumn olvColNotes;
    }
}

