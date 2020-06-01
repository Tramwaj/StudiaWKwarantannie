namespace Tasker
{
    partial class EditDetails
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.olvPlaces = new BrightIdeasSoftware.FastObjectListView();
            this.olvLinks = new BrightIdeasSoftware.FastObjectListView();
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.btnRemovePlace = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.BtnRemoveLink = new System.Windows.Forms.Button();
            this.olvNotes = new BrightIdeasSoftware.FastObjectListView();
            this.rtxNote = new System.Windows.Forms.RichTextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(184, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(81, 66);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(55, 17);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(81, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(81, 106);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(244, 106);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(62, 17);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(321, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pliki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Linki";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 450);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 48);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 450);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 48);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // olvPlaces
            // 
            this.olvPlaces.CellEditUseWholeCell = false;
            this.olvPlaces.HideSelection = false;
            this.olvPlaces.Location = new System.Drawing.Point(488, 50);
            this.olvPlaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.olvPlaces.Name = "olvPlaces";
            this.olvPlaces.ShowGroups = false;
            this.olvPlaces.Size = new System.Drawing.Size(278, 160);
            this.olvPlaces.TabIndex = 10;
            this.olvPlaces.UseCompatibleStateImageBehavior = false;
            this.olvPlaces.View = System.Windows.Forms.View.Details;
            this.olvPlaces.VirtualMode = true;
            // 
            // olvLinks
            // 
            this.olvLinks.CellEditUseWholeCell = false;
            this.olvLinks.HideSelection = false;
            this.olvLinks.Location = new System.Drawing.Point(488, 294);
            this.olvLinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.olvLinks.Name = "olvLinks";
            this.olvLinks.ShowGroups = false;
            this.olvLinks.Size = new System.Drawing.Size(278, 160);
            this.olvLinks.TabIndex = 11;
            this.olvLinks.UseCompatibleStateImageBehavior = false;
            this.olvLinks.View = System.Windows.Forms.View.Details;
            this.olvLinks.VirtualMode = true;
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Location = new System.Drawing.Point(488, 214);
            this.btnAddPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(100, 32);
            this.btnAddPlace.TabIndex = 12;
            this.btnAddPlace.Text = "Dodaj";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            // 
            // btnRemovePlace
            // 
            this.btnRemovePlace.Location = new System.Drawing.Point(728, 214);
            this.btnRemovePlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemovePlace.Name = "btnRemovePlace";
            this.btnRemovePlace.Size = new System.Drawing.Size(38, 32);
            this.btnRemovePlace.TabIndex = 13;
            this.btnRemovePlace.Text = "X";
            this.btnRemovePlace.UseVisualStyleBackColor = true;
            // 
            // btnAddLink
            // 
            this.btnAddLink.Location = new System.Drawing.Point(488, 458);
            this.btnAddLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(100, 32);
            this.btnAddLink.TabIndex = 14;
            this.btnAddLink.Text = "Dodaj";
            this.btnAddLink.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveLink
            // 
            this.BtnRemoveLink.Location = new System.Drawing.Point(728, 458);
            this.BtnRemoveLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveLink.Name = "BtnRemoveLink";
            this.BtnRemoveLink.Size = new System.Drawing.Size(38, 32);
            this.BtnRemoveLink.TabIndex = 15;
            this.BtnRemoveLink.Text = "X";
            this.BtnRemoveLink.UseVisualStyleBackColor = true;
            // 
            // olvNotes
            // 
            this.olvNotes.CellEditUseWholeCell = false;
            this.olvNotes.HideSelection = false;
            this.olvNotes.Location = new System.Drawing.Point(11, 161);
            this.olvNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.olvNotes.Name = "olvNotes";
            this.olvNotes.ShowGroups = false;
            this.olvNotes.Size = new System.Drawing.Size(145, 206);
            this.olvNotes.TabIndex = 16;
            this.olvNotes.UseCompatibleStateImageBehavior = false;
            this.olvNotes.View = System.Windows.Forms.View.Details;
            this.olvNotes.VirtualMode = true;
            // 
            // rtxNote
            // 
            this.rtxNote.Location = new System.Drawing.Point(172, 161);
            this.rtxNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxNote.Name = "rtxNote";
            this.rtxNote.Size = new System.Drawing.Size(288, 250);
            this.rtxNote.TabIndex = 17;
            this.rtxNote.Text = "";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(18, 376);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(84, 35);
            this.btnAddNote.TabIndex = 18;
            this.btnAddNote.Text = "Dodaj";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // EditDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 515);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.rtxNote);
            this.Controls.Add(this.olvNotes);
            this.Controls.Add(this.BtnRemoveLink);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.btnRemovePlace);
            this.Controls.Add(this.btnAddPlace);
            this.Controls.Add(this.olvLinks);
            this.Controls.Add(this.olvPlaces);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblName);
            this.Name = "EditDetails";
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.olvPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private BrightIdeasSoftware.FastObjectListView olvPlaces;
        private BrightIdeasSoftware.FastObjectListView olvLinks;
        private System.Windows.Forms.Button btnAddPlace;
        private System.Windows.Forms.Button btnRemovePlace;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Button BtnRemoveLink;
        private BrightIdeasSoftware.FastObjectListView olvNotes;
        private System.Windows.Forms.RichTextBox rtxNote;
        private System.Windows.Forms.Button btnAddNote;
    }
}