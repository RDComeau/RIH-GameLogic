using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.DemonClasses;
using static RIH_GameLogic.Models.VersionOne.Enums.GameTypes;

namespace RIH_GameLogic.Models.VersionOne.GameTypes
{
    public class Standards : BaseGameTypes
    {
        public override int id { get; set; }
        public override string name { get; set; } = "Standard";
        public override int nameEnum { get; set; } = Convert.ToInt32(GameType.Standard);
        public override Restrictions restrictions { get; set; } = new Restrictions()
        {
            demonClassNumbers = new List<int>()
            {
                Convert.ToInt32(DemonClass.MinionsSuperiorDemons)
            },
            maxDemons = 10,
            souls = 200
        };
        public override DateTime dateCreated { get; set; } = DateTime.UtcNow;
        public override DateTime dateModified { get; set; } = DateTime.UtcNow;
    }
}
