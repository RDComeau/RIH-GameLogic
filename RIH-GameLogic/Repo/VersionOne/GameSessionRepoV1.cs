using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RIH_GameLogic.Helpers.Interfaces;
using RIH_GameLogic.Models.VersionOne;
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
    public class GameSessionRepoV1 : IGameSessionRepoV1
    {
        private ISqlCommands _sql;
        private IConfiguration _config;

        public GameSessionRepoV1(ISqlCommands sql, IConfiguration config)
        {
            _sql = sql;
            _config = config;
        }

        public GameSession CreateNewSession(GameSessionAddRequest createSession)
        {
            GameSession session = null;
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("RIHDatabase")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_sql.NewGameSessionV1(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@SessionName", createSession.sessionName);
                command.Parameters.AddWithValue("@Access", createSession.access);
                command.Parameters.AddWithValue("@DefaultRules", createSession.defaultRules);
                command.Parameters.AddWithValue("@CreatorId", createSession.playorId);
                command.Parameters.AddWithValue("@CabalName", createSession.cabalName);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    session = GameSessionMapper(reader);
                }
            }
            return session;
        }

        public GameSession SelectGame(int id)
        {
            GameSession session = null;
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("RIHDatabase")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_sql.SelectGameBySessionIdV1(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@SessionId", id);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    session = GameSessionMapper(reader);
                }
            }
            return session;
        }

        public GameSession SelectGame(int id, int creatorCabalId)
        {
            GameSession session = null;
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("RIHDatabase")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_sql.SelectGameBySessionIdAndCabalIdV1(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@SessionId", id);
                command.Parameters.AddWithValue("@CreatorCabalId", creatorCabalId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    session = GameSessionMapper(reader);
                }
            }
            return session;
        }

        public GameSession SelectGame(int id, int creatorCabalId, int acceptorCabalId)
        {
            GameSession session = null;
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("RIHDatabase")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_sql.SelectGameBySessionIdAndCabalsIdV1(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@SessionId", id);
                command.Parameters.AddWithValue("@CreatorCabalId", creatorCabalId);
                command.Parameters.AddWithValue("@AcceptorCabalId", acceptorCabalId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    session = GameSessionMapper(reader);
                }
            }
            return session;
        }

        public GameSession AcceptGame(GameSessionAddCabalRequest acceptSession)
        {
            GameSession session = null;
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("RIHDatabase")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_sql.AcceptGameV1(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@SessionId", acceptSession.sessionId);
                command.Parameters.AddWithValue("@CabalName", acceptSession.cabalName);
                command.Parameters.AddWithValue("@DefaultRules", acceptSession.defaultRules);
                command.Parameters.AddWithValue("@AcceptorId", acceptSession.playorId);
                command.Parameters.AddWithValue("@CreatorCabalId", acceptSession.sessionCreatorCabalId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    session = GameSessionMapper(reader);
                }
            }
            return session;
        }

        public void DeleteGame(GameSessionDeleteRequest deleteGame)
        {
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("RIHDatabase")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_sql.DeleteGameV1(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@GameId", deleteGame.SessionId);
                command.Parameters.AddWithValue("@CreatorCabalId", deleteGame.CreatorCabalId);
                command.Parameters.AddWithValue("@AcceptorCabalId", deleteGame.AcceptorCabalId);
                command.ExecuteReader();
            }
        }

        private GameSession GameSessionMapper(SqlDataReader reader)
        {
            int index = 0;

            GameSession session = new GameSession()
            {
                id = reader.GetInt32(index++),
                name = reader.GetName(index++),
                access = reader.GetBoolean(index++),
                defaultRules = reader.GetBoolean(index++),
                creatorId = reader.GetString(index++),
                acceptorId = reader.GetString(index++),
                dateCreated = reader.GetDateTime(index++),
                dateModified = reader.GetDateTime(index++),
            };
            if (reader.FieldCount > 8)
            {
                session.creatorsCabal = JsonConvert.DeserializeObject<Cabal>(reader.GetString(index++));
            }

            if (reader.FieldCount > 9)
            {
                session.acceptorsCabal = JsonConvert.DeserializeObject<Cabal>(reader.GetString(index++));
            }

            return session;
        }
    }
}
