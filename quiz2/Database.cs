using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = "data source = DESKTOP-CPV8G9B\\SQLEXPRESS; database= Library; integrated security = True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}