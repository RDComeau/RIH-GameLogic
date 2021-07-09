using RIH_GameLogic.Models.VersionOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne.Interfaces
{
    public interface IGameSessionRepoV1
    {
        public void CreateNewDefualtSessioin(GameSession session);
        public GameSession SelectGameByGuid(string gameId);
        public void DeleteGameByGuid(string gameId);
    }
}
