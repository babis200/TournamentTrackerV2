using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Model
{
    public class TeamModel
    {
        /// <summary>
        /// A List of Persons that compete for this Team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The Name of the Tean
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Unique ID 
        /// </summary>
        public int Id { get; set; }
    }
}
