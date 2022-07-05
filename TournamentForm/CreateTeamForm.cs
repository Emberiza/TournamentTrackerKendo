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
	public partial class CreateTeamForm : Form
	{
		private List<PersonModel> availableTeamMembers = new List<PersonModel>();
		private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
		private ITeamRequester callingForm;
		public CreateTeamForm(ITeamRequester caller)
		{
			InitializeComponent();

			callingForm = caller;

		}

		private void createMemberButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm())
			{
				PersonModel p = new PersonModel();

				p.PersonName = firstNameValue.Text;
				p.PersonSurname = lastNameValue.Text;
				p.EmailAddress = mailValue.Text;
				p.Age = ageValue.Text;
				p.Rank = rankDropDown.Text;

				GlobalConfig.Connections.CreatePerson(p);

				selectedTeamMembers.Add(p);

			}
			else
			{
				MessageBox.Show("You need to fill in all of the fields.");
			}

			TeamModel t = new TeamModel();

			string teamname1, teamname2;
			teamname1 = firstNameValue.Text;
			teamname2 = lastNameValue.Text;
			t.TeamName = teamname1 + " " + teamname2;
			t.TeamMembers = selectedTeamMembers;

			GlobalConfig.Connections.CreateTeam(t);

			callingForm.TeamComplete(t);

			firstNameValue.Text = string.Empty;
			lastNameValue.Text = string.Empty;
			mailValue.Text = string.Empty;
			ageValue.Text = string.Empty;
			rankLabel.Text = string.Empty;

		}


		private bool ValidateForm()
		{
			if (firstNameValue.Text.Length == 0)
			{
				return false;
			}

			if (lastNameValue.Text.Length == 0)
			{
				return false;
			}

			if (mailValue.Text.Length == 0)
			{
				return false;
			}

			if (ageValue.Text.Length == 0)
			{
				return false;
			}

			if (rankDropDown.Text.Length == 0)
			{
				return false;
			}

			return true;
		}

	}
}