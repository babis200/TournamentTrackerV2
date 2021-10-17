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
    public partial class CreateTournamentForm : Form, IPrizeRequestor, ITeamRequestor
    {

        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeamsAll();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();


        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            SelectTeamCombo.DataSource = null;
            SelectTeamCombo.DataSource = availableTeams;
            SelectTeamCombo.DisplayMember = "TeamName";

            TeamMembersListBox.DataSource = null;
            TeamMembersListBox.DataSource = selectedTeams;
            TeamMembersListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)SelectTeamCombo.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //Call CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show(); 
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the PrizeForm a PrizeModel
            //Take the PrizeModel and add it to selectedPrizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        private void CreateNewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Call CreatePrizeForm
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            //Get back from the TeamForm a TeamModel
            //Take the TeamModel and add it to selectedTeams
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void RemoveTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)TeamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeams.Remove(p);
                availableTeams.Add(p);

                WireUpLists();
            }
        }


        private void RemovePrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            //Validate Data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(EntryFeeText.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid entry fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Create a Tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = TournamentNameBox.Text;
            tm.EntryFee = fee;

            //Could also be:
            // tm.Prizes = selectedPrizes;
            foreach (PrizeModel prize in selectedPrizes)
            {
                tm.Prizes.Add(prize);
            }

            tm.EnteredTeams = selectedTeams;

            //Wire up the Matchups
            TournamentLogic.CreateRounds(tm);

            //Create Tournamnent entry
            //Create all of the Prizes entries
            //Create all of teams entries
            GlobalConfig.Connection.CreateTournament(tm);

            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();           
        }
    }
}
