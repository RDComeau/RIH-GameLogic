using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Helpers.Interfaces
{
    public interface ISqlCommands
    {
        public string NewGame(string userName, bool access, bool defaultGame,
                string sessionGuid, string sessionName, string sessionCreatorId);
        public string SelectGameByGuid(string sessionGuid);
        public string DeleteGameByGuid(string gameGuid);
    }
}
