namespace NoteTakingApp
{
    partial class MainForm
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtFilterTitle = new System.Windows.Forms.TextBox();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.cbWork = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.cbPersonal = new System.Windows.Forms.CheckBox();
            this.cbSchool = new System.Windows.Forms.CheckBox();
            this.gbNotes = new System.Windows.Forms.GroupBox();
            this.lstNotesList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbNoteEdit = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.gbFilter.SuspendLayout();
            this.gbCategory.SuspendLayout();
            this.gbNotes.SuspendLayout();
            this.gbNoteEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.gbCategory);
            this.gbFilter.Controls.Add(this.lblFilterTitle);
            this.gbFilter.Controls.Add(this.txtFilterTitle);
            this.gbFilter.Location = new System.Drawing.Point(12, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(335, 176);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtFilterTitle
            // 
            this.txtFilterTitle.Location = new System.Drawing.Point(46, 31);
            this.txtFilterTitle.Name = "txtFilterTitle";
            this.txtFilterTitle.Size = new System.Drawing.Size(283, 25);
            this.txtFilterTitle.TabIndex = 1;
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Location = new System.Drawing.Point(6, 34);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(34, 19);
            this.lblFilterTitle.TabIndex = 2;
            this.lblFilterTitle.Text = "Title";
            // 
            // cbWork
            // 
            this.cbWork.AutoSize = true;
            this.cbWork.Location = new System.Drawing.Point(6, 24);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(61, 23);
            this.cbWork.TabIndex = 3;
            this.cbWork.Text = "Work";
            this.cbWork.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(311, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.cbSchool);
            this.gbCategory.Controls.Add(this.cbPersonal);
            this.gbCategory.Controls.Add(this.cbWork);
            this.gbCategory.Location = new System.Drawing.Point(6, 62);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(323, 62);
            this.gbCategory.TabIndex = 5;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Category";
            // 
            // cbPersonal
            // 
            this.cbPersonal.AutoSize = true;
            this.cbPersonal.Location = new System.Drawing.Point(224, 24);
            this.cbPersonal.Name = "cbPersonal";
            this.cbPersonal.Size = new System.Drawing.Size(80, 23);
            this.cbPersonal.TabIndex = 3;
            this.cbPersonal.Text = "Personal";
            this.cbPersonal.UseVisualStyleBackColor = true;
            // 
            // cbSchool
            // 
            this.cbSchool.AutoSize = true;
            this.cbSchool.Location = new System.Drawing.Point(115, 24);
            this.cbSchool.Name = "cbSchool";
            this.cbSchool.Size = new System.Drawing.Size(68, 23);
            this.cbSchool.TabIndex = 3;
            this.cbSchool.Text = "School";
            this.cbSchool.UseVisualStyleBackColor = true;
            // 
            // gbNotes
            // 
            this.gbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbNotes.Controls.Add(this.btnRemove);
            this.gbNotes.Controls.Add(this.btnAdd);
            this.gbNotes.Controls.Add(this.lstNotesList);
            this.gbNotes.Location = new System.Drawing.Point(12, 189);
            this.gbNotes.Name = "gbNotes";
            this.gbNotes.Size = new System.Drawing.Size(335, 420);
            this.gbNotes.TabIndex = 1;
            this.gbNotes.TabStop = false;
            this.gbNotes.Text = "Notes";
            // 
            // lstNotesList
            // 
            this.lstNotesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstNotesList.FormattingEnabled = true;
            this.lstNotesList.ItemHeight = 17;
            this.lstNotesList.Location = new System.Drawing.Point(12, 65);
            this.lstNotesList.Name = "lstNotesList";
            this.lstNotesList.Size = new System.Drawing.Size(311, 327);
            this.lstNotesList.TabIndex = 0;
            this.lstNotesList.SelectedIndexChanged += new System.EventHandler(this.lstNotesList_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(102, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbNoteEdit
            // 
            this.gbNoteEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNoteEdit.Controls.Add(this.txtDescription);
            this.gbNoteEdit.Controls.Add(this.txtTitle);
            this.gbNoteEdit.Controls.Add(this.btnSave);
            this.gbNoteEdit.Location = new System.Drawing.Point(354, 13);
            this.gbNoteEdit.Name = "gbNoteEdit";
            this.gbNoteEdit.Size = new System.Drawing.Size(528, 596);
            this.gbNoteEdit.TabIndex = 2;
            this.gbNoteEdit.TabStop = false;
            this.gbNoteEdit.Text = "Note Edit";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(424, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(6, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(516, 25);
            this.txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(6, 61);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(516, 485);
            this.txtDescription.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 619);
            this.Controls.Add(this.gbNoteEdit);
            this.Controls.Add(this.gbNotes);
            this.Controls.Add(this.gbFilter);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(601, 416);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Taking App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.gbNotes.ResumeLayout(false);
            this.gbNoteEdit.ResumeLayout(false);
            this.gbNoteEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox txtFilterTitle;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.CheckBox cbWork;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.CheckBox cbSchool;
        private System.Windows.Forms.CheckBox cbPersonal;
        private System.Windows.Forms.GroupBox gbNotes;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstNotesList;
        private System.Windows.Forms.GroupBox gbNoteEdit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSave;
    }
}

