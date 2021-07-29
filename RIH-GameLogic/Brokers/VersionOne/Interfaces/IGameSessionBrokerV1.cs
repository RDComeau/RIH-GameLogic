using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Brokers.VersionOne.Interfaces
{
    public interface IGameSessionBrokerV1
    {
        public GameSession NewGameSession(GameSessionAddRequest createSession);
        public GameSession SelectGameSession(int id);
        public GameSession SelectGameSession(int id, int creatorCabalId);
        public GameSession SelectGameSession(int id, int creatorCabalId, int acceptorCabalId);
        public GameSession AcceptGame(GameSessionAddCabalRequest acceptSession);
        public void DeleteGameSession(GameSessionDeleteRequest deleteGame);
    }
}
