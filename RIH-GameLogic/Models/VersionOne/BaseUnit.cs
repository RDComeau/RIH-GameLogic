using RIH_GameLogic.Models.VersionOne.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RIH_GameLogic.Models.VersionOne
{

    public abstract class BaseUnit 
    {
        abstract public int id { get; set; }
        abstract public int cost { get; set; }
        abstract public int move { get; set; }
        abstract public int life { get; set; }
        abstract public int combat { get; set; }
        abstract public bool fly { get; set; }
        abstract public string demonName { get; set; }
        abstract public string className { get; set;}
        abstract public int classEnum { get; set; }
        abstract public bool defaultRules { get; set; }
        abstract public DateTime dateCreated { get; set; }
        abstract public DateTime dateModified { get; set; }

        public BaseUnit() { }
        
        public BaseUnit(int Id, int Cost, int Move, int Life,
                        bool Fly, string DemonName, string ClassName, int ClassEnum,
                        bool DefaultRules, DateTime DateCreated, DateTime DateModified)
        {
            id = Id;
            cost = Cost;
            move = Move;
            life = Life;
            fly = Fly;
            demonName = DemonName;
            className = ClassName;
            classEnum = ClassEnum;
            defaultRules = DefaultRules;
            dateCreated = DateCreated;
            dateModified = DateModified;
        }
    }

    public class APIRequest : BaseUnit
    {
        public APIRequest() { }

        public APIRequest(int Id, int Cost, int Move, int Life, bool Fly, string DemonName, string ClassName, int ClassEnum, bool DefaultRules, DateTime DateCreated, DateTime DateModified) 
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
        public override string className { get; set; }
        public override int classEnum { get; set; }
        public override bool defaultRules { get; set; }
        public override DateTime dateCreated { get; set; }
        public override DateTime dateModified { get; set; }
    }

    public class SqlReaderUnit : BaseUnit
    {
        public SqlReaderUnit() { }

        public SqlReaderUnit(int Id, int Cost, int Move, int Life, bool Fly, string DemonName, string ClassName, int ClassEnum, bool DefaultRules, DateTime DateCreated, DateTime DateModified)
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
        public override string className { get; set; }
        public override int classEnum { get; set; }
        public override bool defaultRules { get; set; }
        public override DateTime dateCreated { get; set; }
        public override DateTime dateModified { get; set; }
    }
}
