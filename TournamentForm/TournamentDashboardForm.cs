using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TournamentForm
{
	public partial class TournamentDashboardForm : Form
	{
		List<TournamentModel> tournaments = GlobalConfig.Connections.GetTournament_All();

		public TournamentDashboardForm()
		{
			InitializeComponent();

			WireUpLists();
		}

		private void WireUpLists()
		{
			selectExistingTournamentDropDown.DataSource = tournaments;
			selectExistingTournamentDropDown.DisplayMember = nameof(TournamentModel.TournamentName);
		}

		private void createTournamentButton_Click(object sender, EventArgs e)
		{
			CreateTournamentForm frm = new CreateTournamentForm();
			frm.Show();
		}

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
			TournamentModel tm = (TournamentModel)selectExistingTournamentDropDown.SelectedItem;
			TournamentViewerForm frm = new TournamentViewerForm(tm);
			frm.Show();
		}

    }
}
