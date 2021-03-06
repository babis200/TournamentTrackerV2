using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{

    public static class GlobalConfig
    {

        public const string PrizesFile = "PrizesModels.csv";
        public const string PeopleFile = "PeopleModels.csv";
        public const string TeamsFile = "TeamsModels.csv";
        public const string TournamentFile = "TournamentsModels.csv";
        public const string MatchupsFile = "MatchupsModels.csv";
        public const string MatchupEntriesFile = "MatchupEntriesModels.csv";

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseTypes db)
        {
            
            if (db == DatabaseTypes.Sql)
            {
                SQLConnector sql= new SQLConnector();
                Connection = sql;
                //TODO - Set up the SQL connector properly.
            }
            else if (db == DatabaseTypes.TextFile)
            {
                TextFileConnector text = new TextFileConnector();
                Connection = text;
                //TODO - Set up the Text File connector properly.
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

    
}
