using RIH_GameLogic.Brokers.VersionOne.Interfaces;
using RIH_GameLogic.Models.VersionOne;
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

        public GameSession NewGameSession(GameSession session)
        {
            if (session.defualtRules == Convert.ToBoolean(DefualtRules.No))
            {
                throw new NotImplementedException();
            }
            else
            {
                return _service.CreateNewDefualtSession(session);
            }
        }

        public GameSession SelectGameSessionByGuid(string gameGuid)
        {
            return _service.SelectGameByGuid(gameGuid);
        }

        public void DeleteGameSessionByGuid(string gameGuid)
        {
            _service.DeleteGameByGuid(gameGuid);
        }
    }
}
