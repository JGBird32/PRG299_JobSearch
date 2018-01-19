/*Jansen Ford
 * JobSearch DAL
 * JobSearchDB
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PRG299_JobSearchDAL
{
    public static class JobSearchDB
    {
        public static SqlConnection GetConnection()
        {
            string connectString = "Data Source=localhost\\SQLEXPRESS2014;Initial Catalog=PRG299_JobSearch;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectString);
            return connection;
        }
    }
}
