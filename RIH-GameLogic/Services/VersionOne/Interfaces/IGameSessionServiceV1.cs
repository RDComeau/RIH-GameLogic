using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Services.VersionOne.Interfaces
{
    public interface IGameSessionServiceV1
    {
        public GameSession CreateNewDefualtSession(GameSessionAddRequest createSession);
        public GameSession CreateNewUniqueSession(GameSessionAddRequest createSession);
        public GameSession SelectGame(int id);
        public GameSession SelectGame(int id, int creatorCabalId);
        public GameSession SelectGame(int id, int creatorCabalId, int acceptorCabalId);
        public GameSession AcceptGame(GameSessionAddCabalRequest acceptSession);
        public void DeleteGame(GameSessionDeleteRequest deleteGame);
    }
}
