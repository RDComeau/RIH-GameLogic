using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.Flight;

namespace RIH_GameLogic.Models.VersionOne.Leaders
{
    public class Schemer : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 8;
        public override int life { get; set; } = 11;
        public override int combat { get; set; } = 5;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Schemer";
        public override string className { get; set; } = "Leaders";
    }
}
