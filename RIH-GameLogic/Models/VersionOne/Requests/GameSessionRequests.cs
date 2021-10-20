namespace RIH_GameLogic.Models.VersionOne.Requests
{
    public class GameSessionAddRequest
    {
        public string sessionName { get; set; }
        public bool access { get; set; }
        public bool defaultRules { get; set; }
        public string playorId { get; set; }
        public string cabalName { get; set; }
        public int sessionId { get; set; }
        public int sessionCreatorCabalId { get; set; }
    }

    public class GameSessionDeleteRequest
    {
        public int SessionId { get; set; }
        public int CreatorCabalId { get; set; }
        public int AcceptorCabalId { get; set; }
    }
}
