using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    static class GreedDBCon {
        public static SqlConnection GetConnection() {
            string connectionString = 
                "(localdb)\\ProjectsV13; Initial Catalog = GreedDB;" +
                " Integrated Security = True; Connect Timeout = 30;" +
                " Encrypt = False; TrustServerCertificate = False;" +
                " ApplicationIntent = ReadWrite;" +
                " MultiSubnetFailover = False";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            return con;
        }
    }
}
