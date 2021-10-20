using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.DemonClasses;

namespace RIH_GameLogic.Models.VersionOne.GameTypes
{
    public abstract class BaseGameTypes
    {
        abstract public int id { get; set; }
        abstract public string name { get; set; }
        abstract public int nameEnum { get; set; }
        abstract public Restrictions restrictions { get; set; }
        abstract public DateTime dateCreated { get; set; }
        abstract public DateTime dateModified { get; set; }
    }

    public class Restrictions
    {
        public int id { get; set; }
        public List<int> demonClassNumbers { get; set; }
        [JsonIgnore]
        public string excludedDemons
        {
            get
            {
                if (demonClassNumbers.Any() is false)
                    return JsonConvert.SerializeObject(new List<int> { Convert.ToInt32(DemonClass.None) });
                return JsonConvert.SerializeObject(demonClassNumbers);
            }
            set { }
        }
        public int maxDemons { get; set; }
        public int souls { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.UtcNow;
        public DateTime dateModified { get; set; } = DateTime.UtcNow;
    }

    public class SqlReaderGameType : BaseGameTypes
    {
        override public int id { get; set; }
        override public string name { get; set; }
        override public int nameEnum { get; set; }
        override public Restrictions restrictions { get; set; }
        override public DateTime dateCreated { get; set; }
        override public DateTime dateModified { get; set; }
    }
}
