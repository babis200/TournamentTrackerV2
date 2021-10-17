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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournamentAll();

        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            LoadExistingCombo.DataSource = tournaments;
            LoadExistingCombo.DisplayMember = "TournamentName";
       
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();

            frm.Show();
        }

        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {
            if (LoadExistingCombo.SelectedItem != null)
            {
                TournamentModel tm = (TournamentModel)LoadExistingCombo.SelectedItem;

                TournamentViewerForm form = new TournamentViewerForm(tm);

                form.Show();
            }
            else
            {
                return;
            }
        }

        
    }
}
