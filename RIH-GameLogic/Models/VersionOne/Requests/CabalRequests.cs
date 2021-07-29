using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Models.VersionOne.Requests
{
    public class CabalAddRequests
    {
        public string name { get; set; }
        public bool defaultRules { get; set; }
        public int sessionId { get; set; }
        public string plyorId { get; set; }
    }
}
