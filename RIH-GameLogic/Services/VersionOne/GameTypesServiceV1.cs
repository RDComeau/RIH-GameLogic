using Newtonsoft.Json;
using RIH_GameLogic.Models.VersionOne.GameTypes;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Repo.VersionOne.Interfaces;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.DemonClasses;
using static RIH_GameLogic.Models.VersionOne.Enums.GameTypes;

namespace RIH_GameLogic.Services.VersionOne
{
    public class GameTypesServiceV1 : IGameTypesServiceV1
    {
        IGameTypeRepoV1 _gameTypeRepoV1;

        public GameTypesServiceV1(IGameTypeRepoV1 gameTypeRepoV1)
        {
            _gameTypeRepoV1 = gameTypeRepoV1;
        }

        public BaseGameTypes CreateGameType(GameTypeRequests gameTypeRequests)
        {

            if (gameTypeRequests.nameEnum == Convert.ToInt32(GameType.Custom))
            {
                gameTypeRequests.nameEnum = Convert.ToInt32(GameType.Custom);

                return _gameTypeRepoV1.CreateCustomGameType(gameTypeRequests);
            }
            else
            {
                return _gameTypeRepoV1.CreateGameType(gameTypeRequests);
            }

        }

        public List<BaseGameTypes> GetAllGameTypes()
        {
            return new List<BaseGameTypes>()
            {
                GetCampaignInformation(),
                GetLearningInformation(),
                GetStandardInformation()
            };
        }

        public Campaigns GetCampaignInformation()
        {
            return new Campaigns();
        }

        public Learnings GetLearningInformation()
        {
            return new Learnings();
        }

        public Standards GetStandardInformation()
        {
            return new Standards();
        }
    }
}
