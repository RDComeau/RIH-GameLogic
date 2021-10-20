using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.DemonClasses;
using static RIH_GameLogic.Models.VersionOne.Enums.Flight;

namespace RIH_GameLogic.Models.VersionOne.Devouts
{
    public class Tallyman : BaseUnit
    {
        public Tallyman() { }

        public Tallyman(int Id, int Cost, int Move, int Life, bool Fly, string DemonName, string ClassName, int ClassEnum, bool DefaultRules, DateTime DateCreated, DateTime DateModified)
            : base(Id, Cost, Move, Life, Fly, DemonName, ClassName, ClassEnum, DefaultRules, DateCreated, DateModified)
        {
            this.id = Id;
            this.cost = Cost;
            this.move = Move;
            this.life = Life;
            this.fly = Fly;
            this.demonName = DemonName;
            this.className = ClassName;
            this.classEnum = ClassEnum;
            this.defaultRules = DefaultRules;
            this.dateCreated = DateCreated;
            this.dateModified = DateModified;
        }

        public override int id { get; set; }
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 4;
        public override int life { get; set; } = 11;
        public override int combat { get; set; } = 5;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Tallyman";
        public override string className { get; set; } = "Devouts";
        public override int classEnum { get; set; } = Convert.ToInt32(DemonClass.Devouts);
        public override bool defaultRules { get; set; } = true;
        public override DateTime dateCreated { get; set; } = DateTime.UtcNow;
        public override DateTime dateModified { get; set; } = DateTime.UtcNow;
    }
}
