﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.Flight;

namespace RIH_GameLogic.Models.VersionOne.Minions.GreaterDemons
{
    public class TortureMaster : BaseUnit
    {
        public override int cost { get; set; } = 27;
        public override int move { get; set; } = 6;
        public override int life { get; set; } = 10;
        public override int combat { get; set; } = 6;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Torture Master";
        public override string className { get; set; } = "Minions: Greater Demons";
    }
}
