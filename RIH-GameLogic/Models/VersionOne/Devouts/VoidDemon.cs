﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.Flight;

namespace RIH_GameLogic.Models.VersionOne.Devouts
{
    public class VoidDemon : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 8;
        public override int life { get; set; } = 10;
        public override int combat { get; set; } = 7;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Void Demon";
        public override string className { get; set; } = "Devouts";
    }
}
