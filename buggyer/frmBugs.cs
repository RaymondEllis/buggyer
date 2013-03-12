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

			//Get bugs for the current user.
			if (Server.Open())
			{
				MySqlCommand cmd = new MySqlCommand("SELECT * FROM `" + Server.Table + "` WHERE `assigned to` = '" + Server.UID + "'", Server.Conn);
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
			if (lstBugs.SelectedIndex == -1) return;
			Bug b = Bugs[lstBugs.SelectedIndex];
			lblDescription.Text = b.Description;

			lblReportedBy.Text = b.ReportedBy;
			lblReportedAt.Text = b.ReportedAt.ToString();

			txtAssignedTo.Text = b.AssignedTo;

			txtPriority.Text = b.Priority.ToString();
			txtStatus.Text = b.Status;
			txtComments.Text = b.Comments;
		}

	}
}
