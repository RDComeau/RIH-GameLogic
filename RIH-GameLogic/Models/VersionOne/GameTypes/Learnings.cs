using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.DemonClasses;
using static RIH_GameLogic.Models.VersionOne.Enums.GameTypes;

namespace RIH_GameLogic.Models.VersionOne.GameTypes
{
    public class Learnings : BaseGameTypes
    {
        public override int id { get; set; }
        public override string name { get; set; } = "Learning";
        public override int nameEnum { get; set; } = Convert.ToInt32(GameType.Learning);
        public override Restrictions restrictions { get; set; } = new Restrictions()
        {
            demonClassNumbers = new List<int>()
            {
                Convert.ToInt32(DemonClass.MinionsGreaterDemons),
                Convert.ToInt32(DemonClass.MinionsSuperiorDemons)
            },
            maxDemons = 10,
            souls = 100
        };
         public override DateTime dateCreated { get; set; } = DateTime.UtcNow;
         public override DateTime dateModified { get; set; } = DateTime.UtcNow;
    }
}
