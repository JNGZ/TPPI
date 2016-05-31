namespace TPPI
{
    partial class Journal
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxJournalEntry = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.cboTopic = new System.Windows.Forms.ComboBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.btnNewData = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.groupBoxNav = new System.Windows.Forms.GroupBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxJournalEntry.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxJournalEntry);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxControls);
            this.splitContainer1.Size = new System.Drawing.Size(624, 441);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxJournalEntry
            // 
            this.groupBoxJournalEntry.Controls.Add(this.label1);
            this.groupBoxJournalEntry.Controls.Add(this.dateTimePicker1);
            this.groupBoxJournalEntry.Controls.Add(this.btnNew);
            this.groupBoxJournalEntry.Controls.Add(this.txtTopic);
            this.groupBoxJournalEntry.Controls.Add(this.lblEntry);
            this.groupBoxJournalEntry.Controls.Add(this.cboTopic);
            this.groupBoxJournalEntry.Controls.Add(this.lblTopic);
            this.groupBoxJournalEntry.Controls.Add(this.txtDate);
            this.groupBoxJournalEntry.Controls.Add(this.lblDate);
            this.groupBoxJournalEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxJournalEntry.Location = new System.Drawing.Point(0, 0);
            this.groupBoxJournalEntry.Name = "groupBoxJournalEntry";
            this.groupBoxJournalEntry.Size = new System.Drawing.Size(624, 334);
            this.groupBoxJournalEntry.TabIndex = 0;
            this.groupBoxJournalEntry.TabStop = false;
            this.groupBoxJournalEntry.Text = "Journal Entry";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(481, 88);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New Topic";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNewTopic_Click);
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(203, 151);
            this.txtTopic.Multiline = true;
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(276, 177);
            this.txtTopic.TabIndex = 0;
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Location = new System.Drawing.Point(163, 154);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(31, 13);
            this.lblEntry.TabIndex = 4;
            this.lblEntry.Text = "Entry";
            // 
            // cboTopic
            // 
            this.cboTopic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTopic.FormattingEnabled = true;
            this.cboTopic.Location = new System.Drawing.Point(203, 89);
            this.cboTopic.Name = "cboTopic";
            this.cboTopic.Size = new System.Drawing.Size(272, 21);
            this.cboTopic.TabIndex = 2;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(163, 92);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(34, 13);
            this.lblTopic.TabIndex = 2;
            this.lblTopic.Text = "Topic";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(203, 51);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(272, 20);
            this.txtDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(136, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Entry Date";
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.groupBoxData);
            this.groupBoxControls.Controls.Add(this.groupBoxNav);
            this.groupBoxControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxControls.Location = new System.Drawing.Point(0, 0);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(624, 103);
            this.groupBoxControls.TabIndex = 1;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.btnNewData);
            this.groupBoxData.Controls.Add(this.btnDeleteData);
            this.groupBoxData.Controls.Add(this.btnSaveData);
            this.groupBoxData.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxData.Location = new System.Drawing.Point(314, 16);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(307, 84);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // btnNewData
            // 
            this.btnNewData.Location = new System.Drawing.Point(18, 33);
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(75, 23);
            this.btnNewData.TabIndex = 9;
            this.btnNewData.Text = "&New Record";
            this.btnNewData.UseVisualStyleBackColor = true;
            this.btnNewData.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(205, 33);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteData.TabIndex = 8;
            this.btnDeleteData.Text = "&Delete";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(113, 33);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 7;
            this.btnSaveData.Text = "&Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxNav
            // 
            this.groupBoxNav.Controls.Add(this.lblRecordCount);
            this.groupBoxNav.Controls.Add(this.btnLast);
            this.groupBoxNav.Controls.Add(this.btnNext);
            this.groupBoxNav.Controls.Add(this.btnPrev);
            this.groupBoxNav.Controls.Add(this.btnFirst);
            this.groupBoxNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxNav.Location = new System.Drawing.Point(3, 16);
            this.groupBoxNav.Name = "groupBoxNav";
            this.groupBoxNav.Size = new System.Drawing.Size(305, 84);
            this.groupBoxNav.TabIndex = 0;
            this.groupBoxNav.TabStop = false;
            this.groupBoxNav.Text = "Navigation";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(102, 65);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(73, 13);
            this.lblRecordCount.TabIndex = 4;
            this.lblRecordCount.Text = "Record Count";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(218, 33);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(43, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(151, 33);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(87, 33);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(43, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(28, 33);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(43, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Change date";
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Journal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Program";
            this.Load += new System.EventHandler(this.Journal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxJournalEntry.ResumeLayout(false);
            this.groupBoxJournalEntry.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxNav.ResumeLayout(false);
            this.groupBoxNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxJournalEntry;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.ComboBox cboTopic;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBoxNav;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button btnNewData;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}

