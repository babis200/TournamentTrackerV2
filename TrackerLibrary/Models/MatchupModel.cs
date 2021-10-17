using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Model
{
    public class MatchupModel
    {
        /// <summary>
        /// Unique Identifier for Matchups
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The list of Teams, with their caracteristics which take part in this Matchup
        /// Has to be greater than 2 [>=2]
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        ///  Represents the Winner of the Matchup.
        ///  Can only be one Team.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The ID from the database used to identify the winner.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// At which Round of the Tournament did this Matchup occur.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        //If its the first Team/Competitor
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        } 
                    } else
                    {
                        output = "matchup not yet determined";
                        break; 
                    }
                }
                return output;
            }
        }
    }
}
