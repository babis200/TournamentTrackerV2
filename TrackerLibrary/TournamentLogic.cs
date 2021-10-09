using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackerLibrary.Model;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        //Order our list of teams randomly
        //Check if it is big enough, if not add byes
        //Create the First round of Matchups
        //Create the rest of the rounds

        public static void CreateRounds(TournamentModel model)
        {
            //Order our list of teams randomly
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);

            //Check if it is big enough, if not add byes
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            //Create the First round of Matchups
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            //Create the rest of the rounds
            CreateOtherRounds(model, rounds);
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currentRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match});

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currentRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }

                model.Rounds.Add(currentRound);
                previousRound = currentRound;
                currentRound = new List<MatchupModel>();
                round += 1;
            }
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel currentMatchup = new MatchupModel();


            foreach (TeamModel team in teams)
            {
                currentMatchup.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || currentMatchup.Entries.Count > 1)
                {
                    currentMatchup.MatchupRound = 1;
                    output.Add(currentMatchup);
                    currentMatchup = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }

            return output;
        } 

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output += 1;
                val *= 2;

                return output;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

    }
}
