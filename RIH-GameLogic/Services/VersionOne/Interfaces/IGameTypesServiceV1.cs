using RIH_GameLogic.Models.VersionOne.GameTypes;
using RIH_GameLogic.Models.VersionOne.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Services.VersionOne.Interfaces
{
    public interface IGameTypesServiceV1
    {
        BaseGameTypes CreateGameType(GameTypeRequests gameTypeRequests);
        Campaigns GetCampaignInformation();
        Learnings GetLearningInformation();
        Standards GetStandardInformation();
        List<BaseGameTypes> GetAllGameTypes();
    }
}
