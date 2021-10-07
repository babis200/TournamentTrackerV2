﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Model
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team of the matcup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents the score (points) by THIS particular team.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Represents the Matchup from the previous Round, where thiw team came from
        /// ass the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}