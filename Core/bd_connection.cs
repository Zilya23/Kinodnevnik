using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Configuration;
using System.Data;

namespace Core
{
    class bd_connection
    {
        private static string coonstr = ConfigurationManager.ConnectionStrings["KinodnevnickKursah"].ConnectionString;
        private static IDbConnection connection = new SqlConnection(coonstr);

        public static List<Film> GetFilms()
        {

        }
    }
}
