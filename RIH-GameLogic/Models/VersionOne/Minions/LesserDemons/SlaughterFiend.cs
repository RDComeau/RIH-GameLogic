﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIHGameLogic.Models.Enums.Flight;

namespace RIHGameLogic.Models.VersionOne.Minions.LesserDemons
{
    public class SlaughterFiend : BaseUnit
    {
        public override int cost { get; set; } = 21;
        public override int move { get; set; } = 5;
        public override int life { get; set; } = 10;
        public override int combat { get; set; } = 6;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Slaughter Fiend";
        public override string className { get; set; } = "Minions: Lesser Demons";
    }
}
