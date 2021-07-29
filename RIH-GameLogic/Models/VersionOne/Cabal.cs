using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Models.VersionOne
{
    public class Cabal
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool defaultRules { get; set; }
        public string playorId { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
        public List<BaseUnit> units { get; set; }
    }
}
