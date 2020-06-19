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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.olvPlaces = new BrightIdeasSoftware.FastObjectListView();
            this.olvColDiskPlace = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColDiskPlaceDesc = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColOpen = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvLinks = new BrightIdeasSoftware.FastObjectListView();
            this.olvColLinkPath = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLinkDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.btnRemoveDiskPlace = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.BtnRemoveLink = new System.Windows.Forms.Button();
            this.olvNotes = new BrightIdeasSoftware.FastObjectListView();
            this.olvColNoteName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColNoteDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.rtxNote = new System.Windows.Forms.RichTextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(24, 34);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(24, 86);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(183, 86);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(193, 9);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pliki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Linki";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(44, 366);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 366);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 39);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // olvPlaces
            // 
            this.olvPlaces.AllColumns.Add(this.olvColDiskPlace);
            this.olvPlaces.AllColumns.Add(this.olvColDiskPlaceDesc);
            this.olvPlaces.AllColumns.Add(this.olvColOpen);
            this.olvPlaces.CellEditUseWholeCell = false;
            this.olvPlaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColDiskPlace,
            this.olvColDiskPlaceDesc,
            this.olvColOpen});
            this.olvPlaces.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPlaces.HideSelection = false;
            this.olvPlaces.Location = new System.Drawing.Point(347, 20);
            this.olvPlaces.Margin = new System.Windows.Forms.Padding(2);
            this.olvPlaces.Name = "olvPlaces";
            this.olvPlaces.ShowGroups = false;
            this.olvPlaces.Size = new System.Drawing.Size(336, 152);
            this.olvPlaces.TabIndex = 10;
            this.olvPlaces.UseCompatibleStateImageBehavior = false;
            this.olvPlaces.View = System.Windows.Forms.View.Details;
            this.olvPlaces.VirtualMode = true;
            this.olvPlaces.SelectedIndexChanged += new System.EventHandler(this.olvPlaces_SelectedIndexChanged);
            // 
            // olvColDiskPlace
            // 
            this.olvColDiskPlace.AspectName = "Path";
            this.olvColDiskPlace.Text = "Scieżka";
            this.olvColDiskPlace.Width = 128;
            // 
            // olvColDiskPlaceDesc
            // 
            this.olvColDiskPlaceDesc.AspectName = "Description";
            this.olvColDiskPlaceDesc.Text = "Opis";
            this.olvColDiskPlaceDesc.Width = 128;
            // 
            // olvColOpen
            // 
            this.olvColOpen.AspectName = "IsFile";
            this.olvColOpen.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColOpen.IsButton = true;
            this.olvColOpen.Text = "Otwórz";
            // 
            // olvLinks
            // 
            this.olvLinks.AllColumns.Add(this.olvColLinkPath);
            this.olvLinks.AllColumns.Add(this.olvColLinkDescription);
            this.olvLinks.CellEditUseWholeCell = false;
            this.olvLinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColLinkPath,
            this.olvColLinkDescription});
            this.olvLinks.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvLinks.HideSelection = false;
            this.olvLinks.Location = new System.Drawing.Point(347, 239);
            this.olvLinks.Margin = new System.Windows.Forms.Padding(2);
            this.olvLinks.Name = "olvLinks";
            this.olvLinks.ShowGroups = false;
            this.olvLinks.Size = new System.Drawing.Size(336, 131);
            this.olvLinks.TabIndex = 11;
            this.olvLinks.UseCompatibleStateImageBehavior = false;
            this.olvLinks.View = System.Windows.Forms.View.Details;
            this.olvLinks.VirtualMode = true;
            // 
            // olvColLinkPath
            // 
            this.olvColLinkPath.AspectName = "Path";
            this.olvColLinkPath.Hyperlink = true;
            this.olvColLinkPath.Text = "Link";
            this.olvColLinkPath.Width = 128;
            // 
            // olvColLinkDescription
            // 
            this.olvColLinkDescription.AspectName = "Description";
            this.olvColLinkDescription.Text = "Opis";
            this.olvColLinkDescription.ToolTipText = "Description";
            this.olvColLinkDescription.Width = 200;
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Location = new System.Drawing.Point(366, 174);
            this.btnAddPlace.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(75, 26);
            this.btnAddPlace.TabIndex = 12;
            this.btnAddPlace.Text = "Dodaj";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            this.btnAddPlace.Click += new System.EventHandler(this.btnAddPlace_Click);
            // 
            // btnRemoveDiskPlace
            // 
            this.btnRemoveDiskPlace.Location = new System.Drawing.Point(655, 176);
            this.btnRemoveDiskPlace.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDiskPlace.Name = "btnRemoveDiskPlace";
            this.btnRemoveDiskPlace.Size = new System.Drawing.Size(28, 26);
            this.btnRemoveDiskPlace.TabIndex = 13;
            this.btnRemoveDiskPlace.Text = "X";
            this.btnRemoveDiskPlace.UseVisualStyleBackColor = true;
            this.btnRemoveDiskPlace.Click += new System.EventHandler(this.btnRemoveDiskPlace_Click);
            // 
            // btnAddLink
            // 
            this.btnAddLink.Location = new System.Drawing.Point(366, 372);
            this.btnAddLink.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(75, 26);
            this.btnAddLink.TabIndex = 14;
            this.btnAddLink.Text = "Dodaj";
            this.btnAddLink.UseVisualStyleBackColor = true;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // BtnRemoveLink
            // 
            this.BtnRemoveLink.Location = new System.Drawing.Point(655, 372);
            this.BtnRemoveLink.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRemoveLink.Name = "BtnRemoveLink";
            this.BtnRemoveLink.Size = new System.Drawing.Size(28, 26);
            this.BtnRemoveLink.TabIndex = 15;
            this.BtnRemoveLink.Text = "X";
            this.BtnRemoveLink.UseVisualStyleBackColor = true;
            // 
            // olvNotes
            // 
            this.olvNotes.AllColumns.Add(this.olvColNoteName);
            this.olvNotes.AllColumns.Add(this.olvColNoteDate);
            this.olvNotes.CellEditUseWholeCell = false;
            this.olvNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColNoteName,
            this.olvColNoteDate});
            this.olvNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvNotes.HideSelection = false;
            this.olvNotes.Location = new System.Drawing.Point(11, 112);
            this.olvNotes.Margin = new System.Windows.Forms.Padding(2);
            this.olvNotes.Name = "olvNotes";
            this.olvNotes.ShowGroups = false;
            this.olvNotes.Size = new System.Drawing.Size(219, 114);
            this.olvNotes.TabIndex = 16;
            this.olvNotes.UseCompatibleStateImageBehavior = false;
            this.olvNotes.View = System.Windows.Forms.View.Details;
            this.olvNotes.VirtualMode = true;
            this.olvNotes.SelectedIndexChanged += new System.EventHandler(this.olvNotes_SelectedIndexChanged);
            // 
            // olvColNoteName
            // 
            this.olvColNoteName.AspectName = "Name";
            this.olvColNoteName.Text = "Nazwa";
            this.olvColNoteName.Width = 136;
            // 
            // olvColNoteDate
            // 
            this.olvColNoteDate.AspectName = "TimeCreated";
            this.olvColNoteDate.AspectToStringFormat = "{0:dd/MM/yy}";
            this.olvColNoteDate.Text = "Data dodania";
            this.olvColNoteDate.Width = 70;
            // 
            // rtxNote
            // 
            this.rtxNote.Location = new System.Drawing.Point(11, 240);
            this.rtxNote.Margin = new System.Windows.Forms.Padding(2);
            this.rtxNote.Name = "rtxNote";
            this.rtxNote.Size = new System.Drawing.Size(313, 122);
            this.rtxNote.TabIndex = 17;
            this.rtxNote.Text = "";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(241, 112);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(63, 28);
            this.btnAddNote.TabIndex = 18;
            this.btnAddNote.Text = "Nowa";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(77, 86);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            this.lblType.Visible = false;
            // 
            // EditDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 418);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.rtxNote);
            this.Controls.Add(this.olvNotes);
            this.Controls.Add(this.BtnRemoveLink);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.btnRemoveDiskPlace);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnRemoveDiskPlace;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Button BtnRemoveLink;
        private BrightIdeasSoftware.FastObjectListView olvNotes;
        private System.Windows.Forms.RichTextBox rtxNote;
        private System.Windows.Forms.Button btnAddNote;
        private BrightIdeasSoftware.OLVColumn olvColNoteName;
        private BrightIdeasSoftware.OLVColumn olvColNoteDate;
        private System.Windows.Forms.Label lblDescription;
        private BrightIdeasSoftware.OLVColumn olvColDiskPlace;
        private BrightIdeasSoftware.OLVColumn olvColDiskPlaceDesc;
        private BrightIdeasSoftware.OLVColumn olvColOpen;
        private BrightIdeasSoftware.OLVColumn olvColLinkPath;
        private BrightIdeasSoftware.OLVColumn olvColLinkDescription;
        private System.Windows.Forms.Label lblType;
    }
}