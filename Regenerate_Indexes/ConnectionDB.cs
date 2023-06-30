using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regenerate_Indexes
{
    internal class ConnectionDB
    {
        private string stringConnection;

        public ConnectionDB(string server, string db)
        {
            stringConnection = $"Server={server};Database={db};Trusted_Connection=True;";
        }

        public bool executeProcedure(string procedure)
        {
            try
            {
                using (SqlConnection connectionDB = new SqlConnection(stringConnection))
                {
                    connectionDB.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(procedure, connectionDB))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception error)
            {
                return false;
            }

        }
    }
}
