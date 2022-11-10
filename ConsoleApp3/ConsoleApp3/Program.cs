using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn;
            SqlCommand cmd;
            int i;
            conn = new SqlConnection("Server=DESKTOP-KU4EUIB\\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=true");
            conn.Open();
            try
            {

                cmd = new SqlCommand("delete from Emp_table where Emp_id=@p1", conn);
                cmd.Parameters.AddWithValue("@p1", 3);

                i = cmd.ExecuteNonQuery();
                if (i != 0)
                    Console.WriteLine("Record deleted successfully");
                else
                    Console.WriteLine("Error in query/ connection");




            }
            catch (SqlException se) { Console.WriteLine("Error Message " + se.Message); }
            finally
            {
                conn.Close();
            }
        }
    }
}
