using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Helpers.Interfaces
{
    public interface IConfigHelper
    {
        string RIHConnectionString();
        string NewGameSessionWithoutCabal();
        string NewGameSessionWithCabal();
        string SelectGameBySessionIdV1();
        string SelectGameBySessionIdAndCabalIdV1();
        string SelectGameBySessionIdAndCabalsIdV1();
        string AcceptGameV1();
        string DeleteGameV1();
        string CreateNewCabal();
        string CreateNewDemon();
        string CreateGameType();
        string CreateNewDemonAndReferenceCabal();
        string CreateNewGameTypeRestrictionAndReference();
    }
}
