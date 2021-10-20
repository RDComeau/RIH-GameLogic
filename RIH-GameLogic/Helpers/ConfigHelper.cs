using Microsoft.Extensions.Configuration;
using RIH_GameLogic.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
		private IConfiguration _config;
		public ConfigHelper(IConfiguration config)
        {
			_config = config;
        }

        public string RIHConnectionString()
        {
            return _config.GetConnectionString("RIHDatabase");
        }

        public string NewGameSessionWithoutCabal()
        {
			return _config["SqlProcedures:NewGameSessionWithoutCabal:VersionOne"];
        }

        public string NewGameSessionWithCabal()
        {
            return _config["SqlProcedures:NewGameSessionWithoutCabal:VersionOne"];
        }

        public string SelectGameBySessionIdV1()
        {
            return _config["SqlProcedures:SelectGameSessionById:VersionOne"];
        }

		public string SelectGameBySessionIdAndCabalIdV1()
        {
			return _config["SqlProcedures:SelectGameBySessionIdAndCabalId:VersionOne"];
        }

		public string SelectGameBySessionIdAndCabalsIdV1()
        {
			return _config["SqlProcedures:SelectGameBySessionIdAndCabalsId:VersionOne"];
        }

		public string AcceptGameV1()
        {
			return _config["SqlProcedures:AcceptGame:VersionOne"];
        }

        public string DeleteGameV1()
        {
            return _config["SqlProcedures:DeleteGame:VersionOne"];
        }

        public string CreateNewCabal()
        {
            return _config["SqlProcedures:CreateCabal:VersionOne"];
        }

        public string CreateNewDemon()
        {
            return _config["SqlProcedures:CreateDemon:VersionOne"];
        }

        public string CreateGameType()
        {
            return _config["SqlProcedures:CreateGameType:VersionOne"];
        }

        public string CreateNewDemonAndReferenceCabal()
        {
            return _config["SqlProcedures:CreateDemonAndReferenceCabal:VersionOne"];
        }

        public string CreateNewGameTypeRestrictionAndReference()
        {
            return _config["SqlProcedures:CreateGameTypeRestrictionAndReference:VersionOne"];
        }
    }
}
