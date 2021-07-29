using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Repo.VersionOne.Interfaces;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Services.VersionOne
{
    public class GameSessionServiceV1 : IGameSessionServiceV1
    {
        private IGameSessionRepoV1 _repo;

        public GameSessionServiceV1(IGameSessionRepoV1 repo)
        {
            _repo = repo;
        }

        public GameSession CreateNewDefualtSession(GameSessionAddRequest createSession)
        {
            return _repo.CreateNewSession(createSession);
        }

        public GameSession CreateNewUniqueSession(GameSessionAddRequest createSession)
        {
            return _repo.CreateNewSession(createSession);
        }

        public GameSession SelectGame(int id)
        {
            return _repo.SelectGame(id);
        }

        public GameSession SelectGame(int id, int creatorCabalId)
        {
            return _repo.SelectGame(id, creatorCabalId);
        }

        public GameSession SelectGame(int id, int creatorCabalId, int acceptorCabalId)
        {
            return _repo.SelectGame(id, creatorCabalId, acceptorCabalId);
        }

        public GameSession AcceptGame(GameSessionAddCabalRequest acceptSession)
        {
            return _repo.AcceptGame(acceptSession);
        }

        public void DeleteGame(GameSessionDeleteRequest deleteGame)
        {
            _repo.DeleteGame(deleteGame);
        }
    }
}
