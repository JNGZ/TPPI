namespace TPPI
{
    partial class Topics
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
            this.btnSaveTopic = new System.Windows.Forms.Button();
            this.txtNewTopic = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveTopic
            // 
            this.btnSaveTopic.Location = new System.Drawing.Point(107, 76);
            this.btnSaveTopic.Name = "btnSaveTopic";
            this.btnSaveTopic.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTopic.TabIndex = 0;
            this.btnSaveTopic.Text = "&Save";
            this.btnSaveTopic.UseVisualStyleBackColor = true;
            this.btnSaveTopic.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewTopic
            // 
            this.txtNewTopic.Location = new System.Drawing.Point(35, 35);
            this.txtNewTopic.Name = "txtNewTopic";
            this.txtNewTopic.Size = new System.Drawing.Size(219, 20);
            this.txtNewTopic.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(32, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 2;
            // 
            // Topics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtNewTopic);
            this.Controls.Add(this.btnSaveTopic);
            this.Name = "Topics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Topic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveTopic;
        private System.Windows.Forms.TextBox txtNewTopic;
        private System.Windows.Forms.Label lblStatus;
    }
}