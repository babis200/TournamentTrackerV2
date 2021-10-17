using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> Rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        BindingSource roundsBinding = new BindingSource();
        BindingSource matchupsBinding = new BindingSource();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpLists();
            LoadFormData();
            LoadRounds();
        }

        private void LoadFormData()
        {
            TournamentNameLabel.Text = tournament.TournamentName;

        }
        private void WireUpLists()
        {
            RoundCombo.DataSource = Rounds;

            MatchupListBox.DataSource = selectedMatchups;
            MatchupListBox.DisplayMember = "DisplayName";

        }

        private void LoadRounds()
        {
            Rounds.Clear();

            Rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    Rounds.Add(matchups.First().MatchupRound);
                }
            }
            LoadMatchups(1);
        }

        private void RoundCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundCombo.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            round = (int)RoundCombo.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        selectedMatchups.Add(m);
                    }
                }
            }
            matchupsBinding.ResetBindings(false);
            WireUpLists();
        }

        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadScoreboard((MatchupModel)MatchupListBox.SelectedItem);
        }

        private void LoadScoreboard(MatchupModel m)
        {
            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            TeamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                            TeamOneScore.Text = m.Entries[0].Score.ToString();

                            TeamTwoName.Text = "<bye>";
                            TeamTwoScore.Text = "0";
                        }
                        else
                        {
                            TeamOneName.Text = "Not Yet Set";
                            TeamOneScore.Text = "";
                        }
                    }

                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            TeamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                            TeamTwoScore.Text = m.Entries[1].Score.ToString();
                        }
                        else
                        {
                            TeamTwoName.Text = "Not Yet Set";
                            TeamTwoScore.Text = "";
                        }
                    }
                }
            }

        }
    }
}
