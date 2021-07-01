﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIHGameLogic.Models.Enums.Flight;

namespace RIHGameLogic.Models.VersionOne.Devouts
{
    public class Tallyman : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 4;
        public override int life { get; set; } = 11;
        public override int combat { get; set; } = 5;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Tallyman";
        public override string className { get; set; } = "Devouts";
    }
}
