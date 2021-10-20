using RIH_GameLogic.Models.VersionOne.GameTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Models.VersionOne.Requests
{
    public class GameTypeRequests : BaseGameTypes
    {
        public override int id { get; set; }
        public override string name { get; set; }
        public override int nameEnum { get; set; }
        public override Restrictions restrictions { get; set; }
        public override DateTime dateCreated { get; set; }
        public override DateTime dateModified { get; set; }
    }
}
