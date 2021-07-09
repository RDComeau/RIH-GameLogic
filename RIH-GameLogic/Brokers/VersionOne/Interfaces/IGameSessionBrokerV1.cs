using RIH_GameLogic.Models.VersionOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Brokers.VersionOne.Interfaces
{
    public interface IGameSessionBrokerV1
    {
        public GameSession NewGameSession(GameSession session);
        public GameSession SelectGameSessionByGuid(string gameGuid);
        public void DeleteGameSessionByGuid(string gameGuid);
    }
}
