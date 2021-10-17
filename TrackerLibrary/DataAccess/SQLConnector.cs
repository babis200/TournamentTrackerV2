using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();

                //Send data to SQL
                p.Add("@FirstName", model.FirsName);
                p.Add("@LastName", model.LastName);
                p.Add("@Email", model.EmailAddress);
                p.Add("@Cellphone", model.CellphoneNumber);
                //Receive Id from SQL
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                //Store Id from sql to my model
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }

        /// <summary>
        /// Saves a new prize to the Database
        /// </summary>
        /// <param name="model">The prize info.</param>
        /// <returns>The prize info, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //TODO - Catch errors/Exceptions
            using ( IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();

                //Send data to SQL
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                //Receive Id from SQL
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                //Store Id from sql to my model
                model.Id = p.Get<int>("@Id");
                return model;
            }
            
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();

                //Send data to SQL
                p.Add("@TeamName", model.TeamName);
                
                //Receive Id from SQL
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                //Store Id from sql to my model
                model.Id = p.Get<int>("@Id");

                foreach (PersonModel tm in model.TeamMembers)
                {
                    var n = new DynamicParameters();

                    //Send data to SQL
                    n.Add("@TeamId", model.Id);
                    n.Add("@PersonId", tm.Id);
                    //Receive Id from SQL
                    n.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTeamMembers_Insert", n, commandType: CommandType.StoredProcedure);

                    //Store Id from sql to my model
                    model.Id = n.Get<int>("@Id");
                }


                return model;
            }
        }

        public void CreateTournament(TournamentModel model)
        {
            //TODO - Catch errors/Exceptions
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                SaveTournament(model, connection);

                SaveTournamentPrizes(model, connection);

                SaveTournamentEntries(model, connection);

                SaveTournamentRounds(model, connection);
            }
        }
        private void SaveTournament(TournamentModel model, IDbConnection connection)
        {
            var p = new DynamicParameters();

            //Send data to SQL
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);

            //Receive Id from SQL
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournament_Insert", p, commandType: CommandType.StoredProcedure);

            //Store Id from sql to my model
            model.Id = p.Get<int>("@Id");
        }

        private void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
        {
            foreach (PrizeModel pz in model.Prizes)
            {
                var n = new DynamicParameters();

                //Send data to SQL
                n.Add("@TournamentId", model.Id);
                n.Add("@PrizeId", pz.Id);
                //Receive Id from SQL
                n.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", n, commandType: CommandType.StoredProcedure);

                //Store Id from sql to my model
                model.Id = n.Get<int>("@Id");
            }
        }

        private void SaveTournamentEntries(TournamentModel model, IDbConnection connection)
        {
            foreach (TeamModel tm in model.EnteredTeams)
            {
                var n = new DynamicParameters();

                //Send data to SQL
                n.Add("@TournamentId", model.Id);
                n.Add("@TeamId", tm.Id);
                //Receive Id from SQL
                n.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", n, commandType: CommandType.StoredProcedure);

                //Store Id from sql to my model
                model.Id = n.Get<int>("@Id");
            }
        }

        private void SaveTournamentRounds(TournamentModel model, IDbConnection connection)
        {
            //Loop through the rounds
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.Id = p.Get<int>("@id");

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);

                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            p.Add("ParentMatchupId", entry.ParentMatchup.Id);
                        }

                        if (entry.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingId", null);
                        }
                        else
                        {
                            p.Add("TeamCompetingId", entry.TeamCompeting.Id);
                        }

                        p.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }

        }

        public List<PersonModel> GetPersonAll()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").AsList();
            }

            return output;
        }

        public List<TeamModel> GetTeamsAll()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").AsList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();

                    //Send data to SQL
                    p.Add("@TeamId", team.Id);

                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).AsList();

                }
            }

            return output;
        }

        public List<TournamentModel> GetTournamentAll()
        {
            List<TournamentModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();
                var p = new DynamicParameters();

                //Populate Prizes
                foreach (TournamentModel t in output)
                {
                    p = new DynamicParameters();

                    //Send data to SQL
                    p.Add("@TournamentId", t.Id);

                    t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    //Populate Teams
                    p = new DynamicParameters();

                    //Send data to SQL
                    p.Add("@TournamentId", t.Id);
                    t.EnteredTeams = connection.Query<TeamModel>("dbo.spTeams_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (TeamModel team in t.EnteredTeams)
                    {
                        p = new DynamicParameters();

                        //Send data to SQL
                        p.Add("@TeamId", team.Id);

                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();

                    }
                    p = new DynamicParameters();

                    //Send data to SQL
                    p.Add("@TournamentId", t.Id);

                    //Populate Rounds
                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchup_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    //get matchupEntries for each Matchup
                    foreach (MatchupModel m in matchups)
                    {
                        p = new DynamicParameters();

                        //Send data to SQL
                        p.Add("@MatchupId", m.Id);

                        m.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();

    
                        List<TeamModel> allTeams = GetTeamsAll();

                        if (m.WinnerId > 0)
                        {
                            m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
                        }

                        //Populate each Entry
                        foreach (MatchupEntryModel me in m.Entries)
                        {
                            if (me.TeamCompetingId > 0)
                            {
                                //Pick the Team that belongs to this MatchupEntry
                                me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
                            }

                            if (me.ParentMatchupId > 0)
                            {
                                me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).First();
                            }
                        }
                    }

                    //Finalize the Rounds of our Tournament
                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;

                    foreach (MatchupModel m in matchups)
                    {
                        //if we are done with the previous round
                        if (m.MatchupRound > currRound)
                        {
                            //Add it to the Tournament
                            t.Rounds.Add(currRow);
                            //Initialize for the next Round
                            currRow = new List<MatchupModel>();
                            currRound++;
                        }
                        //Add the Matchup to our current Row
                        currRow.Add(m);
                    }
                    //Add the last Row in the Rounds
                    t.Rounds.Add(currRow);
                }

            }
            return output;
        }
    }
}
