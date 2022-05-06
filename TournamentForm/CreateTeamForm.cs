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

			//CreateSampleData();

			WireUpLists();
        }

		private void CreateSampleData()
        {
			availableTeamMembers.Add(new PersonModel { PersonName = "Tim", PersonSurname = "Corey" });
			availableTeamMembers.Add(new PersonModel { PersonName = "Sue", PersonSurname = "Storm" });

			selectedTeamMembers.Add(new PersonModel { PersonName = "Jane", PersonSurname = "Smith" });
			selectedTeamMembers.Add(new PersonModel { PersonName = "Bill", PersonSurname = "Jones" });
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

				WireUpLists();

				firstNameValue.Text = string.Empty;
				lastNameValue.Text = string.Empty;
				mailValue.Text = string.Empty;
				ageValue.Text = string.Empty;
				
			}
			else
			{
				MessageBox.Show("You need to fill in all of the fields.");
			}
		}
		private void WireUpLists()
		{
			selectTeamMemberDropDown.DataSource = null;

			selectTeamMemberDropDown.DataSource = availableTeamMembers;
			selectTeamMemberDropDown.DisplayMember = "FullName";

			teamMembersListBox.DataSource = null;

			teamMembersListBox.DataSource = selectedTeamMembers;
			teamMembersListBox.DisplayMember = "FullName";
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

        private void addMemberButton_Click(object sender, EventArgs e)
        {
			PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

			if (p != null)
			{
				availableTeamMembers.Remove(p);
				selectedTeamMembers.Add(p);

				WireUpLists();
			}
		}

        private void deleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
			PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

			if (p != null)
			{
				selectedTeamMembers.Remove(p);
				availableTeamMembers.Add(p);

				WireUpLists();
			}
		}

        private void createTeamButton_Click(object sender, EventArgs e)
        {
			TeamModel t = new TeamModel();

			t.TeamName = newTeamNameValue.Text;
			t.TeamMembers = selectedTeamMembers;

			GlobalConfig.Connections.CreateTeam(t);

			callingForm.TeamComplete(t);

			this.Close();
		}
    }
}
