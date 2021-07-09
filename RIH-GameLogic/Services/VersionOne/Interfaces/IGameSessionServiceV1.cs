using RIH_GameLogic.Models.VersionOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Services.VersionOne.Interfaces
{
    public interface IGameSessionServiceV1
    {
        public GameSession CreateNewDefualtSession(GameSession session);
        public GameSession SelectGameByGuid(string gameGuid);
        public void DeleteGameByGuid(string gameGuid);
    }
}
