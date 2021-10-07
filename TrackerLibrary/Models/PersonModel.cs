using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Model
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string CellphoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirsName} {LastName}";
            }
        }
    }
}
