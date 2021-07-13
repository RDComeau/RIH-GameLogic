﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.Flight;

namespace RIH_GameLogic.Models.VersionOne.Minions.LesserDemons
{
    public class Mephit : BaseUnit
    {
        public override int cost { get; set; } = 16;
        public override int move { get; set; } = 9;
        public override int life { get; set; } = 7;
        public override int combat { get; set; } = 3;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.Yes);
        public override string demonName { get; set; } = "Mephit";
        public override string className { get; set; } = "Minions: Lesser Demons";
    }
}
