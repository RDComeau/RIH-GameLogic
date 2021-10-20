using Newtonsoft.Json;
using RIH_GameLogic.Helpers.Interfaces;
using RIH_GameLogic.Models.VersionOne.GameTypes;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Repo.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne
{
    public class GameTypeRepoV1 : IGameTypeRepoV1
    {
        IConfigHelper _configHelper;


        public GameTypeRepoV1(IConfigHelper configHelper)
        {
            _configHelper = configHelper;
        }

        public BaseGameTypes CreateGameType(GameTypeRequests gameTypeRequests)
        {
            BaseGameTypes customGame = null;
            using (SqlConnection connection = new SqlConnection(_configHelper.RIHConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_configHelper.CreateGameType(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@GameTypeName", gameTypeRequests.name);
                command.Parameters.AddWithValue("@GameTypeNumber", gameTypeRequests.nameEnum);
                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    customGame = GameTypeMapper(reader);
                }
            }
            return customGame;
        }

        public BaseGameTypes CreateCustomGameType(GameTypeRequests gameTypeRequests)
        {
            BaseGameTypes customGame = null;
            using (SqlConnection connection = new SqlConnection(_configHelper.RIHConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_configHelper.CreateNewGameTypeRestrictionAndReference(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@GameTypeName", gameTypeRequests.name);
                command.Parameters.AddWithValue("@GameTypeNumber", gameTypeRequests.nameEnum);
                command.Parameters.AddWithValue("@ExcludedDemons", gameTypeRequests.restrictions.excludedDemons);
                command.Parameters.AddWithValue("@MaxDemons", gameTypeRequests.restrictions.maxDemons);
                command.Parameters.AddWithValue("@Souls", gameTypeRequests.restrictions.souls);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    customGame = GameTypeMapper(reader);
                }
            }
            return customGame;
        }

        private BaseGameTypes GameTypeMapper(SqlDataReader reader)
        {
            int index = 0;
            SqlReaderGameType sqlReaderGameType = new SqlReaderGameType()
            {
                id = reader.GetInt32(index++),
                name = reader.GetString(index++),
                nameEnum = reader.GetInt32(index++),
                dateCreated = reader.GetDateTime(index++),
                dateModified = reader.GetDateTime(index++)
            };
            if(reader.FieldCount > 4)
            {
                sqlReaderGameType.restrictions = new Restrictions()
                {
                    id = reader.GetInt32(index++),
                    demonClassNumbers = JsonConvert.DeserializeObject<List<int>>(reader.GetString(index++)),
                    maxDemons = reader.GetInt32(index++),
                    souls = reader.GetInt32(index++),
                    dateCreated = reader.GetDateTime(index++),
                    dateModified = reader.GetDateTime(index++)
                };
            }
            return sqlReaderGameType;
        }
    }
}
