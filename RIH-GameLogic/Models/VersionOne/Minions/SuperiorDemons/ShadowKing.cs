﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIHGameLogic.Models.Enums.Flight;

namespace RIHGameLogic.Models.VersionOne.Minions.SuperiorDemons
{
    public class ShadowKing : BaseUnit
    {
        public override int cost { get; set; } = 33;
        public override int move { get; set; } = 7;
        public override int life { get; set; } = 10;
        public override int combat { get; set; } = 6;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.Yes);
        public override string demonName { get; set; } = "Shadow King";
        public override string className { get; set; } = "Minions: Superior Demons";
    }
}
