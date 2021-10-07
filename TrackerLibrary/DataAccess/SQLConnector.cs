using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
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



        // TODO - Make the CreatePrize method actually save to the Database.
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
    }
}
