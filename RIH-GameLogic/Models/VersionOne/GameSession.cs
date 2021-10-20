using System;

namespace RIH_GameLogic.Models.VersionOne
{
    public class GameSession
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool access { get; set; }
        public bool defaultRules { get; set; }
        public string creatorId { get; set; }
        public string acceptorId { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
        public Cabal creatorsCabal { get; set; }
        public Cabal acceptorsCabal { get; set; }
    }
}
