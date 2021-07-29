using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RIH_GameLogic.Models.VersionOne;
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
        IConfiguration _config;

        public CabalRepoV1(IConfiguration config)
        {
            _config = config;
        }

        public Cabal CreateCabalInSQL(List<BaseUnit> newCabal)
        {
            Cabal cabal = null;
            using (SqlConnection connection = new SqlConnection(""))
            {
                SqlCommand command = new SqlCommand("commandString", connection);
                command.Connection.Open();
                SqlParameter cabalParameter = command.Parameters.AddWithValue("", newCabal);
                cabalParameter.SqlDbType = SqlDbType.Structured;

                command.ExecuteReader();

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
                units = JsonConvert.DeserializeObject<List<BaseUnit>>(reader.GetString(index++)),
                dateCreated = reader.GetDateTime(index++),
                dateModified = reader.GetDateTime(index)
            };
        }
    }
}
