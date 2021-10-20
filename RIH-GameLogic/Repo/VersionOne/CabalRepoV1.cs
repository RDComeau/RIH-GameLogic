using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RIH_GameLogic.Helpers.Interfaces;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Repo.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne
{
    public class CabalRepoV1 : ICabalRepoV1
    {
        private IConfigHelper _configHelper;

        public CabalRepoV1(IConfigHelper configHelper)
        {
            _configHelper = configHelper;
        }

        public Cabal CreateCabal(CabalAddRequests cabalAddRequests)
        {
            Cabal cabal = null;
            using (SqlConnection connection = new SqlConnection(_configHelper.RIHConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_configHelper.CreateNewCabal(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@CabalName", cabalAddRequests.name);
                command.Parameters.AddWithValue("@PlayorId", cabalAddRequests.playorId);
                command.Parameters.AddWithValue("@DefaultRules", cabalAddRequests.defaultRules);

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    cabal = CabalMapper(reader);
                }
            }
            return cabal;
        }

        private Cabal CabalMapper(SqlDataReader reader)
        {
            int index = 0;

            return new Cabal()
            {
                id = reader.GetInt32(index++),
                name = reader.GetString(index++),
                defaultRules = reader.GetBoolean(index++),
                playorId = reader.GetString(index++),
                dateCreated = reader.GetDateTime(index++),
                dateModified = reader.GetDateTime(index)
            };
        }
    }
}
