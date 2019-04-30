using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace Controller
{
    public class EmployeeController
    {
        //dao
        private EmployeeDao dao;

        //constructor
        public EmployeeController()
        {
            dao = new EmployeeDao();
        }

        //method - add employee
        public ResultEnum Add(Employee emp)
        {
            try
            {
                dao.Insert(emp);
                return ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging
                Console.WriteLine("Error - EmployeeDao/Insert - " + ex.Message);
                return ResultEnum.Fail;
            }
        }

        //method - update employee
        public ResultEnum Update(Employee emp)
        {
            try
            {
                dao.UpdateEmployee(emp);
                return ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging
                Console.WriteLine("Error - EmployeeDao/Update - " + ex.Message);
                return ResultEnum.Fail;
            }
        }

        //method - select all employees
        public Result<Employee> SelectAll()
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                result.Data = dao.SelectAll();
                result.Status =  ResultEnum.Success;
            }
            catch (Exception ex)
            {

                //logging
                Console.WriteLine("Error - EmployeeDao/SelectAll - " + ex.Message);
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        //method - select all employees sorted by first name
        public Result<Employee> SelectAllSortedByFirstName()
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                result.Data = dao.SelectEmployeeSortedFirstName();
                result.Status = ResultEnum.Success;
            }
            catch (Exception ex)
            {

                //logging
                Console.WriteLine("Error - EmployeeDao/SelectEmployeeSortedFirstName - " + ex.Message);
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        //method - select employee by id
        public Result<Employee> SelectById(int empid)
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                result.Data = dao.SelectEmpId(empid);
                result.Status = ResultEnum.Success;
            }
            catch (Exception ex)
            {

                //logging
                Console.WriteLine("Error - EmployeeDao/SelectById - " + ex.Message);
                result.Status = ResultEnum.Fail;
            }
            return result;
        }
        //method - select employee by email
        public Result<Employee> SelectByEmail(string email)
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                result.Data = dao.SelectByEmail(email);
                result.Status = ResultEnum.Success;
            }
            catch (Exception ex)
            {

                //logging
                Console.WriteLine("Error - EmployeeDao/SelectByEmail - " + ex.Message);
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

    }
}
