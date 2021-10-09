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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequestor callingForm;
        public CreatePrizeForm(IPrizeRequestor caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void PlaceNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameText.Text,
                    PlaceNumberText.Text,
                    PrizeAmountText.Text,
                    PrizePercentageText.Text);

                               
                GlobalConfig.Connection.CreatePrize(model);

                //Return to the form that called CreatePrizeForm the PrizeModel
                callingForm.PrizeComplete(model);

                this.Close();

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please try again.");
            }
        }

        private bool ValidateForm()
        {
            //TODO - Return Error Message for each check.
            bool output = true;
            int placeNumber = 0;

            if(!(int.TryParse(PlaceNumberText.Text, out placeNumber)))
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }


            if (PlaceNameText.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValidate = decimal.TryParse(PrizeAmountText.Text, out prizeAmount);
            bool prizePercentageValidate = int.TryParse(PrizePercentageText.Text, out prizePercentage);

            if (prizePercentageValidate == false || prizeAmountValidate == false)
            {
                output = false;
            }
            
            if (prizePercentage <= 0 && prizeAmount <= 0)
            {
                output = false;
            }
            if (0 < prizePercentage || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }

        private void PrizeAmountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrizePercentageText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
