using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RIH_GameLogic.Models.VersionOne.Requests
{
    public class CabalAddRequests
    {
        public CabalAddRequests() { }

        public CabalAddRequests(string Name, bool DefaultRules, string PlayorId, List<APIRequest> Units)
        {
            this.name = Name;
            this.defaultRules = DefaultRules;
            this.playorId = PlayorId;
            this.units = Units;
        }

        public string name { get; set; }
        public bool defaultRules { get; set; }
        public string playorId { get; set; }
        public List<APIRequest> units { get; set; } 
    }
}
