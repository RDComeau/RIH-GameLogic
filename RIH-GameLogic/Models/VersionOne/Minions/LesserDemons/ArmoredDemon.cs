using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.DemonClasses;
using static RIH_GameLogic.Models.VersionOne.Enums.Flight;

namespace RIH_GameLogic.Models.VersionOne.Minions.LesserDemons
{
    public class ArmoredDemon : BaseUnit
    {
        public ArmoredDemon() { }

        public ArmoredDemon(int Id, int Cost, int Move, int Life, bool Fly, string DemonName, string ClassName, int ClassEnum, bool DefaultRules, DateTime DateCreated, DateTime DateModified)
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
        public override int cost { get; set; } = 22;
        public override int move { get; set; } = 4;
        public override int life { get; set; } = 13;
        public override int combat { get; set; } = 5;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
        public override string demonName { get; set; } = "Armored Demon";
        public override string className { get; set; } = "Minions: Lesser Demons";
        public override int classEnum { get; set; } = Convert.ToInt32(DemonClass.MinionsLesserDemons);
        public override bool defaultRules { get; set; } = true;
        public override DateTime dateCreated { get; set; } = DateTime.UtcNow;
        public override DateTime dateModified { get; set; } = DateTime.UtcNow;
    }
}
