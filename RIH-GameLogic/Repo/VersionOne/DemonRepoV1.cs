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
    public class DemonRepoV1 : IDemonRepoV1
    {
        IConfigHelper _configHelper;

        public DemonRepoV1(IConfigHelper configHelper)
        {
            _configHelper = configHelper;
        }

        public BaseUnit AddDemon(BaseUnit unit)
        {
            BaseUnit baseUnit = null;
            using (SqlConnection connection = new SqlConnection(_configHelper.RIHConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_configHelper.CreateNewDemon(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@Cost", unit.cost);
                command.Parameters.AddWithValue("@Move", unit.move);
                command.Parameters.AddWithValue("@Life", unit.life);
                command.Parameters.AddWithValue("@Combat", unit.combat);
                command.Parameters.AddWithValue("@Fly", unit.fly);
                command.Parameters.AddWithValue("@DemonName", unit.demonName);
                command.Parameters.AddWithValue("@ClassName", unit.className);
                command.Parameters.AddWithValue("@DefaultRules", unit.defaultRules);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    baseUnit = UnitMapper(reader);
                }
            }
            return baseUnit;
        }

        public BaseUnit AddDemon(BaseUnit unit, int cabalId)
        {
            BaseUnit baseUnit = null;
            using (SqlConnection connection = new SqlConnection(_configHelper.RIHConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_configHelper.CreateNewDemonAndReferenceCabal(), connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@Cost", unit.cost);
                command.Parameters.AddWithValue("@Move", unit.move);
                command.Parameters.AddWithValue("@Life", unit.life);
                command.Parameters.AddWithValue("@Combat", unit.combat);
                command.Parameters.AddWithValue("@Fly", unit.fly);
                command.Parameters.AddWithValue("@DemonName", unit.demonName);
                command.Parameters.AddWithValue("@ClassName", unit.className);
                command.Parameters.AddWithValue("@DefaultRules", unit.defaultRules);
                command.Parameters.AddWithValue("@CabalId", cabalId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    baseUnit = UnitMapper(reader);
                }
            }
            return baseUnit;
        }

        private BaseUnit UnitMapper(SqlDataReader reader)
        {
            return new SqlReaderUnit()
            {
                id = Convert.ToInt32(reader["Id"].ToString()),
                cost = Convert.ToInt32(reader["Cost"].ToString()),
                move = Convert.ToInt32(reader["Move"].ToString()),
                life = Convert.ToInt32(reader["Life"].ToString()),
                combat = Convert.ToInt32(reader["Combat"].ToString()),
                fly = Convert.ToBoolean(reader["Fly"].ToString()),
                demonName = reader["DemonName"].ToString(),
                className = reader["ClassName"].ToString(),
                defaultRules = Convert.ToBoolean(reader["DefaultRules"].ToString()),
                dateCreated = Convert.ToDateTime(reader["DateCreated"]),
                dateModified = Convert.ToDateTime(reader["DateModified"])
            };
        }
    }
}
