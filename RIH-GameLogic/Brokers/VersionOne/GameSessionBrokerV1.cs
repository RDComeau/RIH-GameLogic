using RIH_GameLogic.Brokers.VersionOne.Interfaces;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.Rules;

namespace RIH_GameLogic.Brokers.VersionOne
{
    public class GameSessionBrokerV1 : IGameSessionBrokerV1
    {
        private IGameSessionServiceV1 _service;

        public GameSessionBrokerV1(IGameSessionServiceV1 service)
        {
            _service = service;
        }

        public GameSession NewGameSession(GameSessionAddRequest createSession)
        {
            if (createSession.defaultRules == Convert.ToBoolean(DefualtRules.No))
            {
                return _service.CreateNewUniqueSession(createSession);
            }
            else
            {
                return _service.CreateNewDefualtSession(createSession);
            }
        }

        public GameSession SelectGameSession(int id)
        {
            return _service.SelectGame(id);
        }

        public GameSession SelectGameSession(int id, int creatorCabalId)
        {
            return _service.SelectGame(id, creatorCabalId);
        }

        public GameSession SelectGameSession(int id, int creatorCabalId, int acceptorCabalId)
        {
            return _service.SelectGame(id, creatorCabalId, acceptorCabalId);
        }

        public GameSession AcceptGame(GameSessionAddCabalRequest acceptSession)
        {
            return _service.AcceptGame(acceptSession);
        }

        public void DeleteGameSession(GameSessionDeleteRequest deleteGame)
        {
            _service.DeleteGame(deleteGame);
        }
    }
}
