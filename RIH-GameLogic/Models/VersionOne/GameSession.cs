using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Models.VersionOne
{
    public class GameSession
    {
        public string userName { get; set; }
        public string sessionName { get; set; }
        public bool access { get; set; }
        public bool defualtRules { get; set; }
        public string identifier { get; set; }
        public string creator { get; set; }
        public string acceptor { get; set; }
    }
}
