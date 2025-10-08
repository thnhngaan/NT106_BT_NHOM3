using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace NT106_2._2
{
    internal class Connection
    {
        private static string stringConnection = @"Server=localhost;Database=USERS;User Id=sa;Password=JoJo@368108;TrustServerCertificate=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
