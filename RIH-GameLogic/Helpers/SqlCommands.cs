using Microsoft.Extensions.Configuration;
using RIH_GameLogic.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Helpers
{
    public class SqlCommands : ISqlCommands
    {
		private IConfiguration _config;
		public SqlCommands(IConfiguration config)
        {
			_config = config;
        }

        public string NewGameSessionV1()
        {
			return _config["SqlProcedures:NewGameSession:VersionOne"];
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
    }
}
