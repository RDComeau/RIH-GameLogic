using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne.Interfaces
{
    public interface IGameSessionRepoV1
    {
        public GameSession CreateNewSessionWithoutCabal(GameSessionAddRequest createSession);
        public GameSession CreateNewSessionWithCabal(GameSessionAddRequest createSession);
        public GameSession SelectGame(int id);
        public GameSession SelectGame(int id, int creatorCabalId);
        public GameSession SelectGame(int id, int creatorCabalId, int acceptorCabalId);
        public GameSession AcceptGame(GameSessionAddRequest acceptSession);
        public void DeleteGame(GameSessionDeleteRequest deleteGame);
    }
}
