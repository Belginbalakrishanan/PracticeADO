using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PracticeADO
{
    internal class DiscontinuesDB
    {
        public static void SelectType()
        {
            string constr=ConfigurationManager.ConnectionStrings["cn"].ToString();
            SqlConnection con = new SqlConnection(constr);
            string query = "select * from employee";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,con);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            DataTable tables = dataset.Tables[0];
            foreach(DataRow row in tables.Rows)
            {
                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2]);
            }
        }
    }
}
