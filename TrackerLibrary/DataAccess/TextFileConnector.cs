using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Model;
using TrackerLibrary.DataAccess.TextHelper;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextFileConnector : IDataConnection
    {
        //TODO - Make them obsolete by using GlobalConfig versions everywhere
        private const string PrizesFile = "PrizesModels.csv";
        private const string PeopleFile = "PeopleModels.csv";
        private const string TeamsFile = "TeamsModels.csv";
        private const string TournamentFile = "TournamentsModels.csv";
        private const string MatchupsFile = "MatchupsModels.csv";
        private const string MatchupEntriesFile = "MatchupEntriesModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            //Load TextFile
            //Convert the text to PersonModel
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count() > 0)
            {
                //Get the latest Id and add 1
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;

            }

            //Add new record with its id
            model.Id = currentId;
            people.Add(model);

            //Save new data to the text File
            people.SaveToPersonFile(PeopleFile);

            return model;
        }

        // TODO - Make the CreatePrize method actually save to the Database.
        /// <summary>
        /// Saves a new prize to a Text File
        /// </summary>
        /// <param name="model">The prize info.</param>
        /// <returns>The prize info, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load TextFile
            //Convert the text to PrizeModel
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;
            if (prizes.Count() > 0)
            {
                //Get the latest Id and add 1
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;

            }

            //Add new record with its id
            model.Id = currentId;
            prizes.Add(model);

            //Save new data to the text File
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            //Load TextFile
            //Convert the text to TeamModel
            List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            int currentId = 1;
            if (teams.Count() > 0)
            {
                //Get the latest Id and add 1
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;

            }

            //Add new record with its id
            model.Id = currentId;
            teams.Add(model);

            //Save new data to the text File
            teams.SaveToTeamFile(TeamsFile);

            return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            //Load TextFile
            //Convert the text to TournamentModel
            List<TournamentModel> tournaments = TournamentFile
                                                .FullFilePath()
                                                .LoadFile()
                                                .ConvertToTournamentModels(TeamsFile, PeopleFile, PrizesFile);

            int currentId = 1;
            if (tournaments.Count() > 0)
            {
                //Get the latest Id and add 1
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;

            }

            //Add new record with its id
            model.Id = currentId;

            model.SaveToRoundsFile();

            tournaments.Add(model);

            //Save new data to the text File
            tournaments.SaveToTournamentFile(TournamentFile);
        }

        public List<PersonModel> GetPersonAll()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeamsAll()
        {
            return TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);                             
        }

        public List<TournamentModel> GetTournamentAll()
        {
            return TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels(TeamsFile, PeopleFile, PrizesFile); 
        }
    }
}