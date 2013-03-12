﻿namespace buggyer
{
	partial class frmLogin
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
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUID = new System.Windows.Forms.TextBox();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chkSaveServer = new System.Windows.Forms.CheckBox();
			this.chkSaveDatabase = new System.Windows.Forms.CheckBox();
			this.chkSaveUID = new System.Windows.Forms.CheckBox();
			this.txtTable = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chkSaveTable = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(88, 114);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(164, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// txtUID
			// 
			this.txtUID.Location = new System.Drawing.Point(88, 88);
			this.txtUID.Name = "txtUID";
			this.txtUID.Size = new System.Drawing.Size(164, 20);
			this.txtUID.TabIndex = 0;
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(88, 10);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(164, 20);
			this.txtServer.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Server:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDatabase
			// 
			this.txtDatabase.Location = new System.Drawing.Point(88, 36);
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(164, 20);
			this.txtDatabase.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Database:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "User name:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Password:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkSaveServer
			// 
			this.chkSaveServer.Checked = true;
			this.chkSaveServer.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSaveServer.Location = new System.Drawing.Point(258, 9);
			this.chkSaveServer.Name = "chkSaveServer";
			this.chkSaveServer.Size = new System.Drawing.Size(55, 20);
			this.chkSaveServer.TabIndex = 5;
			this.chkSaveServer.Text = "Save";
			this.chkSaveServer.UseVisualStyleBackColor = true;
			// 
			// chkSaveDatabase
			// 
			this.chkSaveDatabase.Checked = true;
			this.chkSaveDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSaveDatabase.Location = new System.Drawing.Point(258, 36);
			this.chkSaveDatabase.Name = "chkSaveDatabase";
			this.chkSaveDatabase.Size = new System.Drawing.Size(55, 20);
			this.chkSaveDatabase.TabIndex = 4;
			this.chkSaveDatabase.Text = "Save";
			this.chkSaveDatabase.UseVisualStyleBackColor = true;
			// 
			// chkSaveUID
			// 
			this.chkSaveUID.Location = new System.Drawing.Point(258, 88);
			this.chkSaveUID.Name = "chkSaveUID";
			this.chkSaveUID.Size = new System.Drawing.Size(55, 20);
			this.chkSaveUID.TabIndex = 2;
			this.chkSaveUID.Text = "Save";
			this.chkSaveUID.UseVisualStyleBackColor = true;
			// 
			// txtTable
			// 
			this.txtTable.Location = new System.Drawing.Point(88, 62);
			this.txtTable.Name = "txtTable";
			this.txtTable.Size = new System.Drawing.Size(164, 20);
			this.txtTable.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Table:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkSaveTable
			// 
			this.chkSaveTable.Location = new System.Drawing.Point(258, 62);
			this.chkSaveTable.Name = "chkSaveTable";
			this.chkSaveTable.Size = new System.Drawing.Size(55, 20);
			this.chkSaveTable.TabIndex = 3;
			this.chkSaveTable.Text = "Save";
			this.chkSaveTable.UseVisualStyleBackColor = true;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 158);
			this.Controls.Add(this.chkSaveTable);
			this.Controls.Add(this.chkSaveUID);
			this.Controls.Add(this.chkSaveDatabase);
			this.Controls.Add(this.chkSaveServer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDatabase);
			this.Controls.Add(this.txtServer);
			this.Controls.Add(this.txtTable);
			this.Controls.Add(this.txtUID);
			this.Controls.Add(this.txtPassword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "buggyer - Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.Shown += new System.EventHandler(this.frmLogin_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUID;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDatabase;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkSaveServer;
		private System.Windows.Forms.CheckBox chkSaveDatabase;
		private System.Windows.Forms.CheckBox chkSaveUID;
		private System.Windows.Forms.TextBox txtTable;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkSaveTable;
	}
}