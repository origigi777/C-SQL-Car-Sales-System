using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace CarSalesDB.General
{
    public class AppSettings
    {
        public static string connectionString()
        {
            return ConfigurationManager
            .ConnectionStrings["CarSalesSQLdb"].ConnectionString;
        }
        SqlConnection con = new SqlConnection();
    }
}
