using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DataAccess
{
    public class EmployeeDao
    {
        //method - insert new Employee
        public void Insert(Employee emp)
        {
            //connect
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.GetConnectionString();
            conn.Open();

            using (conn)
            {
                //command object - run SQL
                SqlCommand command = new SqlCommand("sp_Employees_Insert", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@firstName", emp.FirstName));
                command.Parameters.Add(new SqlParameter("@lastName", emp.LastName));
                command.Parameters.Add(new SqlParameter("@email", emp.Email));
                command.Parameters.Add(new SqlParameter("@phone", emp.Phone));
                command.Parameters.Add(new SqlParameter("@dob", emp.DOB));

                //run
                command.ExecuteNonQuery();
            }
        }

        //method - update Employee
        public void UpdateEmployee(Employee emp)
        {
            //connect
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.GetConnectionString();
            conn.Open();

            using (conn)
            {
                //command
                SqlCommand command = new SqlCommand("sp_Employees_Update", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@empid", emp.EmpID));
                command.Parameters.Add(new SqlParameter("@firstname", emp.FirstName));
                command.Parameters.Add(new SqlParameter("@lastname", emp.LastName));
                command.Parameters.Add(new SqlParameter("@email", emp.Email));
                command.Parameters.Add(new SqlParameter("@phone", emp.Phone));
                command.Parameters.Add(new SqlParameter("@dob", emp.DOB));

                //run
                command.ExecuteNonQuery();
            }
        }

        //method - select all employees
        public List<Employee> SelectAll()
        {
            List<Employee> list = new List<Employee>();

            //connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.GetConnectionString();
            conn.Open();

            using (conn)
            {
                //command
                SqlCommand command = new SqlCommand("sp_Employees_SelectAll", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                //run
                SqlDataReader reader = command.ExecuteReader();

                //loop to map each reader row
                while (reader.Read())
                {
                    //convert row into object
                    Employee emp = new Employee();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    emp.DOB = Convert.ToDateTime(reader["DOB"]);

                    //add to list
                    list.Add(emp);
                }
                return list;
            }
        }

        //method - select all employees sorted by first name
        public List<Employee> SelectEmployeeSortedFirstName()
        {
            List<Employee> list = new List<Employee>();

            //connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.GetConnectionString();
            conn.Open();

            using (conn)
            {
                //command
                SqlCommand command = new SqlCommand("sp_Employees_SelectAllSortedFirstName", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                //run
                SqlDataReader reader = command.ExecuteReader();

                //loop to map each reader row
                while (reader.Read())
                {
                    //convert row into object
                    Employee emp = new Employee();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    emp.DOB = Convert.ToDateTime(reader["DOB"]);

                    //add to list
                    list.Add(emp);
                }
                return list;
            }
        }

        //method - select employee by Id
        public List<Employee> SelectEmpId(int empid)

        {
            List<Employee> list = new List<Employee>();
            //connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.GetConnectionString();
            conn.Open();

            using (conn)
            {
                
                //command
                SqlCommand command = new SqlCommand("sp_Employees_SelectID", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@empid", empid));


                //run
                SqlDataReader reader = command.ExecuteReader();

                //loop to map each reader row
                while (reader.Read())
                {
                    //convert row into object
                    Employee emp = new Employee();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    emp.DOB = Convert.ToDateTime(reader["DOB"]);

                    list.Add(emp);
                }
                return list;
            }
        }

        //method - select employee by Email
        public List<Employee> SelectByEmail(string email)
        {
            List<Employee> list = new List<Employee>();

            //connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.GetConnectionString();
            conn.Open();

            using (conn)
            {
                //command
                SqlCommand command = new SqlCommand("sp_Employees_SelectEmail", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@email", email));


                //run
                SqlDataReader reader = command.ExecuteReader();

                //loop to map each reader row
                while (reader.Read())
                {
                    //convert row into object
                    Employee emp = new Employee();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    emp.DOB = Convert.ToDateTime(reader["DOB"]);

                    list.Add(emp);
                }
                return list ;
            }
        }
    }
}
