using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeADO
{
    internal class ParameterQuery
    {
        public static void ParameterQueries()
        {
            string constr=ConfigurationManager.ConnectionStrings["cn"].ToString();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string query = "insert into employee values(@empid,@ename,@deptno)";
            SqlCommand cmd = new SqlCommand(query, con);

           
            SqlParameter idpm = new SqlParameter("@empid",SqlDbType.Int);
            idpm.Direction = ParameterDirection.Input;
            Console.WriteLine("Enter id");
            idpm.Value=int.Parse(Console.ReadLine());
            cmd.Parameters.Add(idpm);

            SqlParameter namepm = new SqlParameter("@ename", SqlDbType.VarChar,20);
            namepm.Direction = ParameterDirection.Input;
            Console.WriteLine("Enter name");
            namepm.Value =Console.ReadLine();
            cmd.Parameters.Add(namepm);

            SqlParameter deptpm = new SqlParameter("@deptno", SqlDbType.Int);
            deptpm.Direction = ParameterDirection.Input;
            Console.WriteLine("Enter deptno");
            deptpm.Value = int.Parse(Console.ReadLine());
            cmd.Parameters.Add(deptpm);

            cmd.ExecuteNonQuery();
        }
    }
}
