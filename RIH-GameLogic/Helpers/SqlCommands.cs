using RIH_GameLogic.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Helpers
{
    public class SqlCommands : ISqlCommands
    {
        public SqlCommands()
        {

        }

        public string NewGame(string userName, bool access, bool defaultGame,
            string sessionGuid, string sessionName, string sessionCreatorId)
        {
            return $@"INSERT INTO Session
                        (UserName,
                         Access,
                         Rules,
                         SessionGuid,
                         SessionName,
                         Creator
                         )
                         values
                        ('{userName}',
                          {access},
                          {defaultGame},
                         '{sessionGuid}',
                         '{sessionName}',
                         '{sessionCreatorId}'
                        );";
        }

        public string SelectGameByGuid(string sessionGuid)
        {
            return $@"SELECT
                        UserName,
                        Access,
                        Rules,
                        SessionGuid,
                        SessionName
                    FROM Session
                    WHERE SessionGuid = '{sessionGuid}';";
        }

        public string DeleteGameByGuid(string gameGuid)
        {
            return $@"DELETE
                      FROM Session
                      WHERE Id = {gameGuid};";
        }
    }
}
