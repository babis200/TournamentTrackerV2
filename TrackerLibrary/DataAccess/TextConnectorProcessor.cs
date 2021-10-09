using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess.TextHelper
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string filename)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{filename}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>(); //Empty List of strings
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');    //split into columns

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirsName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                output.Add(p);
            }

            return output;
        }

        public  static  List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');    //split into columns

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = float.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string PeopleFile)
        {
            //Id,TeamName,list of Ids seperated by the |
            //3,Babis's Team,1|2|3
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> p = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');    //split into columns

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];
                
                string[] personIds = cols[2].Split('|');
                foreach (string id in personIds)
                {   
                    //we use First() because this returns a list of 1 but C# errors so we take only the first (of a list with only 1)
                    t.TeamMembers.Add(p.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }

            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(
            this List<string> lines, string TeamsFile, string PeopleFile, string PrizesFile)
        {
            //Id,TournamentName,EntryFee,(id1|id2|id3 - Entered Teams),(id1|id2|id3 - Prizes),(Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');    //split into columns

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    //we use First() because this returns a list of 1 but C# errors so we take only the first (of a list with only 1)
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(tm);

                string[] prizesIds = cols[4].Split('|');
                foreach (string id in prizesIds)
                {
                    //we use First() because this returns a list of 1 but C# errors so we take only the first (of a list with only 1)
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(tm);

                //TODO - Capture Round Info
            }
            return output;
        }

        public static void SaveToPersonFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirsName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel p in models)
            {
                lines.Add($"{p.Id},{p.TeamName},{ConvertPeopleListToString(p.TeamMembers)}");
            }

            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel p in models)
            {
                lines.Add($@"{p.Id},
                    {p.TournamentName},
                    {p.EntryFee},
                    {ConvertTeamsListToString(p.EnteredTeams)},
                    {ConvertPrizesListToString(p.Prizes)}, 
                    {ConvertRoundListToString(p.Rounds)}");
            }

            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return output;
            }

            foreach (List<MatchupModel> t in rounds)
            {
                output += $"{ConvertMatchupListToString(t)}|";
            }

            //Remove the trailing (last) | (pipe)
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return output;
            }

            foreach (MatchupModel t in matchups)
            {
                output += $"{t.Id}^";
            }

            //Remove the trailing (last) | (pipe)
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizesListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return output;
            }

            foreach (PrizeModel t in prizes)
            {
                output += $"{t.Id}|";
            }

            //Remove the trailing (last) | (pipe)
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertTeamsListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return output;
            }

            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }

            //Remove the trailing (last) | (pipe)
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return output;
            }

            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }

            //Remove the trailing (last) | 
            output = output.Substring(0, output.Length - 1);

            return output;
        }

    }
}
