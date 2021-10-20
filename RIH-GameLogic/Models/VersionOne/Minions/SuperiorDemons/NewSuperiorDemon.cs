using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.DemonClasses;

namespace RIH_GameLogic.Models.VersionOne.Minions.SuperiorDemons
{
    public class NewSuperiorDemon : BaseUnit
    {
        public NewSuperiorDemon() { }

        public NewSuperiorDemon(int Id, int Cost, int Move, int Life, bool Fly, string DemonName, string ClassName, int ClassEnum, bool DefaultRules, DateTime DateCreated, DateTime DateModified)
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
        public override int cost { get; set; }
        public override int move { get; set; }
        public override int life { get; set; }
        public override int combat { get; set; }
        public override bool fly { get; set; }
        public override string demonName { get; set; }
        public override string className { get; set; } = "Minions: SuperiorDemons";
        public override int classEnum { get; set; } = Convert.ToInt32(DemonClass.MinionsSuperiorDemons);
        public override bool defaultRules { get; set; } = false;
        public override DateTime dateCreated { get; set; } = DateTime.UtcNow;
        public override DateTime dateModified { get; set; } = DateTime.UtcNow;
    }
}
