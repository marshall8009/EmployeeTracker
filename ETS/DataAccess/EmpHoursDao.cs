using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DataAccess
{
    public class EmpHoursDao
    {
        //method - add employee work hours
        public void AddHours(EmpHours emp)
        {
            //connect
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.GetConnectionString();
            conn.Open();

            using (conn)
            {
                //command - run sql
                SqlCommand command = new SqlCommand("sp_EmpHours_Insert", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@empid", emp.EmpID));
                command.Parameters.Add(new SqlParameter("@workdate", emp.WorkDate));
                command.Parameters.Add(new SqlParameter("@hours", emp.Hours));

                //run
                command.ExecuteNonQuery();
            }
        }

        //method - Display employee hours and name
        public List<EmpHours> DisplayHours(int empid)
        {
            List<EmpHours> list = new List<EmpHours>();
            //connect
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.GetConnectionString();
            conn.Open();

            using (conn)
            {
                //command
                SqlCommand command = new SqlCommand("sp_EmpHours_DisplayWorkinfo", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@empid", empid));

                //run
                SqlDataReader reader = command.ExecuteReader();

                //loop to map each row
                while (reader.Read())
                {
                    //convert row into objects
                    EmpHours emp = new EmpHours();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                    emp.Hours = Convert.ToDecimal(reader["Hours"]);

                    list.Add(emp);
                }
                return list;
            }
        }
    }
}
