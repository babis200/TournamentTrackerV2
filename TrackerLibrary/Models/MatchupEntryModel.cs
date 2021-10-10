using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Model
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Unique Identifier for MatchupEntries
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents one team of the matcup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents the score (points) by THIS particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the Matchup from the previous Round, where thiw team came from
        /// ass the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
