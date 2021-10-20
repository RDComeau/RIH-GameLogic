using RIH_GameLogic.Models.VersionOne.GameTypes;
using RIH_GameLogic.Models.VersionOne.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne.Interfaces
{
    public interface IGameTypeRepoV1
    {
        BaseGameTypes CreateGameType(GameTypeRequests gameTypeRequests);
        BaseGameTypes CreateCustomGameType(GameTypeRequests gameTypeRequests);
    }
}
