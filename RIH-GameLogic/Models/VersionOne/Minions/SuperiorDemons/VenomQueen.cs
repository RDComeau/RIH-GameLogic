﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIHGameLogic.Models.Enums.Flight;

namespace RIHGameLogic.Models.VersionOne.Minions.SuperiorDemons
{
    public class VenomQueen : BaseUnit
    {
        public override int cost { get; set; } = 31;
        public override int move { get; set; } = 5;
        public override int life { get; set; } = 13;
        public override int combat { get; set; } = 5;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Venom Queen";
        public override string className { get; set; } = "Minions: Superior Demons";
    }
}
