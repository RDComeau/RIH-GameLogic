using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Helpers.Interfaces
{
    public interface ISqlCommands
    {
        public string NewGameSessionV1();
        public string SelectGameBySessionIdV1();
        public string SelectGameBySessionIdAndCabalIdV1();
        public string SelectGameBySessionIdAndCabalsIdV1();
        public string AcceptGameV1();
        public string DeleteGameV1();
    }
}
