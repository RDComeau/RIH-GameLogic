using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Models.VersionOne.Requests
{
    public class GameSessionAddRequest
    {
        public string sessionName { get; set; }
        public bool access { get; set; }
        public bool defaultRules { get; set; }
        public string playorId { get; set; }
        public string cabalName { get; set; }
    }

    public class GameSessionAddCabalRequest : GameSessionAddRequest
    {
        public int sessionId { get; set; }
        public int sessionCreatorCabalId { get; set; }
    }

    public class GameSessionDeleteRequest
    {
        public int SessionId { get; set; }
        public int CreatorCabalId { get; set; }
        public int AcceptorCabalId { get; set; }
    }
}
