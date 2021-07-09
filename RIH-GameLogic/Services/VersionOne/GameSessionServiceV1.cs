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
        public Guid CreateNewSession()
        {
            return Guid.NewGuid();
        }
    }
}
