namespace buggyer
{
	partial class frmBugs
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
			this.lstBugs = new System.Windows.Forms.ListBox();
			this.grpBugInfo = new System.Windows.Forms.GroupBox();
			this.txtComments = new System.Windows.Forms.TextBox();
			this.lblReportedAt = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblReportedBy = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAssignedTo = new System.Windows.Forms.TextBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPriority = new System.Windows.Forms.TextBox();
			this.btnNewBug = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.grpBugInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstBugs
			// 
			this.lstBugs.FormattingEnabled = true;
			this.lstBugs.Location = new System.Drawing.Point(12, 12);
			this.lstBugs.Name = "lstBugs";
			this.lstBugs.Size = new System.Drawing.Size(392, 95);
			this.lstBugs.TabIndex = 0;
			this.lstBugs.SelectedIndexChanged += new System.EventHandler(this.lstBugs_SelectedIndexChanged);
			// 
			// grpBugInfo
			// 
			this.grpBugInfo.Controls.Add(this.txtComments);
			this.grpBugInfo.Controls.Add(this.lblReportedAt);
			this.grpBugInfo.Controls.Add(this.lblDescription);
			this.grpBugInfo.Controls.Add(this.lblReportedBy);
			this.grpBugInfo.Controls.Add(this.label1);
			this.grpBugInfo.Controls.Add(this.label7);
			this.grpBugInfo.Controls.Add(this.label2);
			this.grpBugInfo.Controls.Add(this.label6);
			this.grpBugInfo.Controls.Add(this.txtAssignedTo);
			this.grpBugInfo.Controls.Add(this.txtStatus);
			this.grpBugInfo.Controls.Add(this.label3);
			this.grpBugInfo.Controls.Add(this.label5);
			this.grpBugInfo.Controls.Add(this.txtPriority);
			this.grpBugInfo.Location = new System.Drawing.Point(12, 113);
			this.grpBugInfo.Name = "grpBugInfo";
			this.grpBugInfo.Size = new System.Drawing.Size(392, 198);
			this.grpBugInfo.TabIndex = 1;
			this.grpBugInfo.TabStop = false;
			this.grpBugInfo.Text = "Bug:";
			// 
			// txtComments
			// 
			this.txtComments.Location = new System.Drawing.Point(206, 29);
			this.txtComments.Multiline = true;
			this.txtComments.Name = "txtComments";
			this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtComments.Size = new System.Drawing.Size(179, 161);
			this.txtComments.TabIndex = 3;
			// 
			// lblReportedAt
			// 
			this.lblReportedAt.Location = new System.Drawing.Point(82, 104);
			this.lblReportedAt.Name = "lblReportedAt";
			this.lblReportedAt.Size = new System.Drawing.Size(118, 20);
			this.lblReportedAt.TabIndex = 2;
			this.lblReportedAt.Text = "<Date>";
			this.lblReportedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(6, 29);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(194, 55);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "<Description>";
			// 
			// lblReportedBy
			// 
			this.lblReportedBy.Location = new System.Drawing.Point(82, 84);
			this.lblReportedBy.Name = "lblReportedBy";
			this.lblReportedBy.Size = new System.Drawing.Size(118, 20);
			this.lblReportedBy.TabIndex = 2;
			this.lblReportedBy.Text = "<Name>";
			this.lblReportedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Description:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Status:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Reported by:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Priority:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAssignedTo
			// 
			this.txtAssignedTo.Location = new System.Drawing.Point(85, 127);
			this.txtAssignedTo.Name = "txtAssignedTo";
			this.txtAssignedTo.Size = new System.Drawing.Size(115, 20);
			this.txtAssignedTo.TabIndex = 3;
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(85, 170);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(115, 20);
			this.txtStatus.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Reported at:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Assigned to:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPriority
			// 
			this.txtPriority.Location = new System.Drawing.Point(85, 150);
			this.txtPriority.Name = "txtPriority";
			this.txtPriority.Size = new System.Drawing.Size(115, 20);
			this.txtPriority.TabIndex = 3;
			// 
			// btnNewBug
			// 
			this.btnNewBug.Location = new System.Drawing.Point(329, 317);
			this.btnNewBug.Name = "btnNewBug";
			this.btnNewBug.Size = new System.Drawing.Size(75, 23);
			this.btnNewBug.TabIndex = 2;
			this.btnNewBug.Text = "New bug";
			this.btnNewBug.UseVisualStyleBackColor = true;
			this.btnNewBug.Click += new System.EventHandler(this.btnNewBug_Click);
			// 
			// btnReload
			// 
			this.btnReload.Location = new System.Drawing.Point(248, 317);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 2;
			this.btnReload.Text = "Reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// frmBugs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 347);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.btnNewBug);
			this.Controls.Add(this.grpBugInfo);
			this.Controls.Add(this.lstBugs);
			this.Name = "frmBugs";
			this.Text = "buggyer - Bugs";
			this.Load += new System.EventHandler(this.frmBugs_Load);
			this.grpBugInfo.ResumeLayout(false);
			this.grpBugInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstBugs;
		private System.Windows.Forms.GroupBox grpBugInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtComments;
		private System.Windows.Forms.TextBox txtAssignedTo;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblReportedBy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblReportedAt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.TextBox txtPriority;
		private System.Windows.Forms.Button btnNewBug;
		private System.Windows.Forms.Button btnReload;
	}
}