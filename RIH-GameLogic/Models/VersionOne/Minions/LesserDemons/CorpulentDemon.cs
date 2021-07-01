﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIHGameLogic.Models.Enums.Flight;

namespace RIHGameLogic.Models.VersionOne.Minions.LesserDemons
{
    public class CorpulentDemon : BaseUnit
    {
        public override int cost { get; set; } = 17;
        public override int move { get; set; } = 4;
        public override int life { get; set; } = 15;
        public override int combat { get; set; } = 4;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Corpulent Demon";
        public override string className { get; set; } = "Minions: Lesser Demons";
    }
}
