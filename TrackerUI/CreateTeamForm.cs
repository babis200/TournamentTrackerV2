using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPersonAll();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();



        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }


       
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirsName = "Babis", LastName = "Balt" });
            availableTeamMembers.Add(new PersonModel { FirsName = "Joe", LastName = "smith" });
            
            selectedTeamMembers.Add(new PersonModel { FirsName = "Mike", LastName = "Jordan" });
            selectedTeamMembers.Add(new PersonModel { FirsName = "Pin", LastName = "Yiua" });
        }

        private void WireUpLists()
        {
            SelectMemberCombo.DataSource = null;    //NEEDS to be null first before refreshing

            SelectMemberCombo.DataSource = availableTeamMembers;
            SelectMemberCombo.DisplayMember = "FullName";      // how a Person is going to be displayed

            TournamentPlayersListBox.DataSource = null;     //NEEDS to be null first before refreshing

            TournamentPlayersListBox.DataSource = selectedTeamMembers;
            TournamentPlayersListBox.DisplayMember = "FullName";      // how a Person is going to be displayed
        }

        private void CreateNewMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirsName = FirstNameTextBox.Text;
                p.LastName = LastNameTextBox.Text;
                p.EmailAddress = EmailTextBox.Text;
                p.CellphoneNumber = CellphoneText.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                EmailTextBox.Text = "";
                CellphoneText.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fillin all the fields.");
            }
        }

        private bool ValidateForm()
        {
            //TODO - Complete validation to the form

            if (FirstNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (LastNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (EmailTextBox.Text.Length == 0)
            {
                return false;
            }
            
            // TODO - Make check for digits ONLY
            if (CellphoneText.Text.Length == 0)
            {
                
                return false;
            }
            return  true;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectMemberCombo.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
               
                WireUpLists();
            }            
                        
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {

            PersonModel p = (PersonModel)TournamentPlayersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel model = new TeamModel();

            model.TeamName = TeamNameBox.Text;
            model.TeamMembers = selectedTeamMembers;

            model = GlobalConfig.Connection.CreateTeam(model);

            //TODO - If we are not closing this form after creation reset ALL the fields
        }

       
    }
}
