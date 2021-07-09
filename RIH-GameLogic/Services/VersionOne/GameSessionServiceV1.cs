using RIH_GameLogic.Models.VersionOne;
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

        public GameSession CreateNewDefualtSession(GameSession session)
        {
            session.identifier = Guid.NewGuid().ToString();
            _repo.CreateNewDefualtSessioin(session);
            return session;
        }

        public GameSession SelectGameByGuid(string gameGuid)
        {
            return  _repo.SelectGameByGuid(gameGuid);
        }

        public void DeleteGameByGuid(string gameGuid)
        {
            _repo.DeleteGameByGuid(gameGuid);
        }
    }
}
