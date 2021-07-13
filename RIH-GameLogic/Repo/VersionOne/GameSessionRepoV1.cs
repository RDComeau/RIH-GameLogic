using Microsoft.Data.Sqlite;
using RIH_GameLogic.Helpers.Interfaces;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Repo.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne
{
    public class GameSessionRepoV1 : IGameSessionRepoV1
    {
        private ISqlCommands _sql;

        public GameSessionRepoV1(ISqlCommands sql)
        {
            _sql = sql;
        }

        public void CreateNewDefualtSessioin(GameSession session)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = _sql.NewGame(session.userName, session.access, session.defualtRules, session.identifier, session.sessionName, session.creator);
                command.ExecuteReader();
            }
        }

        public GameSession SelectGameByGuid(string gameId)
        {
            GameSession session = new GameSession();

            using (SqliteConnection connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = _sql.SelectGameByGuid(gameId.ToString());

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        session = GameSessionMapper(reader);
                    }
                }
            }
            return session;
        }

        public void DeleteGameByGuid(string gameId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = _sql.DeleteGameByGuid(gameId.ToString());
                command.ExecuteReader();
            }
        }

        private GameSession GameSessionMapper(SqliteDataReader reader)
        {
            int index = 0;

            return new GameSession()
            {
                userName = reader.GetString(index++),
                access = reader.GetBoolean(index++),
                defualtRules = reader.GetBoolean(index++),
                identifier = reader.GetGuid(index++).ToString(),
                sessionName = reader.GetString(index)
            };
        }
    }
}
