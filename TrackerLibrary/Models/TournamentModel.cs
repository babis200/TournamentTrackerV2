using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Model
{
    public class TournamentModel
    {
        /// <summary>
        /// The Name of the Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The amount of money required to enter the Tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a List of the contestants of the Tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        
        /// <summary>
        /// Represents the list of Prizes awarded at this Tournament. 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The amount of Rounds this Tournament consists of. It is represented as the 
        /// List of Matchups that are included at each Round and then a list of those Rounds.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
