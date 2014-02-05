namespace buggyer
{
	partial class frmNewBug
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
			this.lblReportedBy = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAssignedTo = new System.Windows.Forms.TextBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPriority = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtSummary = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtComments = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblReportedBy
			// 
			this.lblReportedBy.Location = new System.Drawing.Point(94, 103);
			this.lblReportedBy.Name = "lblReportedBy";
			this.lblReportedBy.Size = new System.Drawing.Size(115, 20);
			this.lblReportedBy.TabIndex = 2;
			this.lblReportedBy.Text = "<Name>";
			this.lblReportedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Description:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(15, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Status:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Reported by:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(15, 153);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Priority:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAssignedTo
			// 
			this.txtAssignedTo.Location = new System.Drawing.Point(94, 128);
			this.txtAssignedTo.Name = "txtAssignedTo";
			this.txtAssignedTo.Size = new System.Drawing.Size(115, 20);
			this.txtAssignedTo.TabIndex = 2;
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(94, 178);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(115, 20);
			this.txtStatus.TabIndex = 4;
			this.txtStatus.Text = "Open";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(15, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Assigned to:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPriority
			// 
			this.txtPriority.Location = new System.Drawing.Point(94, 153);
			this.txtPriority.Name = "txtPriority";
			this.txtPriority.Size = new System.Drawing.Size(115, 20);
			this.txtPriority.TabIndex = 3;
			this.txtPriority.Text = "1";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(15, 45);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDescription.Size = new System.Drawing.Size(194, 55);
			this.txtDescription.TabIndex = 1;
			// 
			// txtSummary
			// 
			this.txtSummary.Location = new System.Drawing.Point(91, 6);
			this.txtSummary.Name = "txtSummary";
			this.txtSummary.Size = new System.Drawing.Size(300, 20);
			this.txtSummary.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Summary:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(310, 207);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtComments
			// 
			this.txtComments.Location = new System.Drawing.Point(212, 42);
			this.txtComments.Multiline = true;
			this.txtComments.Name = "txtComments";
			this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtComments.Size = new System.Drawing.Size(179, 156);
			this.txtComments.TabIndex = 5;
			// 
			// frmNewBug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 242);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtComments);
			this.Controls.Add(this.txtPriority);
			this.Controls.Add(this.lblReportedBy);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSummary);
			this.Controls.Add(this.txtAssignedTo);
			this.Controls.Add(this.label6);
			this.Name = "frmNewBug";
			this.Text = "buggyer - New bug";
			this.Load += new System.EventHandler(this.frmNewBug_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblReportedBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAssignedTo;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPriority;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtSummary;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtComments;

	}
}