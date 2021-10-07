using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Model
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique Identifier for Prizes
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Number One (1) is for First place, Two (2) for Second Place ...
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// E.G. First Place or Winner ...
        /// Second Place or Runner Up ...
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The ammount of money which is given the the winner of THIS prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The amount rewarded for the prize can be a percentage of the Tournament earnings INSTEAD of a flat amount.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
                
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;

            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }
    }
}
