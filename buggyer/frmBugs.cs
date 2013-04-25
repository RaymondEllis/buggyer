using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace buggyer
{
	public partial class frmBugs : Form
	{
		public List<Bug> Bugs = new List<Bug>();
		public frmBugs()
		{
			InitializeComponent();
		}

		private void frmBugs_Load(object sender, EventArgs e)
		{

			Reload();
		}

		public void Reload()
		{
			grpBugInfo.Enabled = false;
			lstBugs.Items.Clear();

			//Get bugs for the current user.
			if (Server.Open())
			{
				MySqlCommand cmd = new MySqlCommand("SELECT * FROM `" + Server.Table + "` WHERE `assigned to` = '" + Server.UID + "'", Server.Connection);
				MySqlDataReader reader = null;
				try
				{
					reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						Bug bug = new Bug(reader);
						Bugs.Add(bug);
						lstBugs.Items.Add(bug.ToString());
					}
				}
				catch (MySqlException ex) { Server.ShowError(ex.Message); }
			}
			Server.Close();
		}

		private void lstBugs_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstBugs.SelectedIndex == -1)
			{
				grpBugInfo.Enabled = false;
				return;
			}
			Bug bug = Bugs[lstBugs.SelectedIndex];
			lblDescription.Text = bug.Description;

			lblReportedBy.Text = bug.ReportedBy;
			lblReportedAt.Text = bug.ReportedAt.ToString();

			txtAssignedTo.Text = bug.AssignedTo;

			txtPriority.Text = bug.Priority.ToString();
			txtStatus.Text = bug.Status;
			txtComments.Text = bug.Comments;

			grpBugInfo.Enabled = true;
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			Reload();
		}

		private void btnNewBug_Click(object sender, EventArgs e)
		{
			frmNewBug frmNewBug = new frmNewBug();
			frmNewBug.ShowDialog();
			Reload();
		}

	}
}
