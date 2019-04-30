using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Controller
{
    public class EmpHoursController
    {
        //dao
        private EmpHoursDao dao;

        //constructor
        public EmpHoursController()
        {
            dao = new EmpHoursDao();
        }

        //method add employee hours
        public ResultEnum AddHours(EmpHours emp)
        {
            try
            {
                dao.AddHours(emp);
                return ResultEnum.Success;
            }
            catch (Exception ex)
            {
                //logging
                Console.WriteLine("Error - EmpHoursDao/AddHours - " + ex.Message);
                return ResultEnum.Fail;
            }
        }

        //method - display employee work info
        public Result<EmpHours> DisplayWorkInfo(int empid)
        {
            Result<EmpHours> result = new Result<EmpHours>();
            try
            {
                result.Data = dao.DisplayHours(empid);
                result.Status = ResultEnum.Success;
            }
            catch (Exception ex)
            {

                //logging
                Console.WriteLine("Error - EmpHoursDao/DisplayHours - " + ex.Message);
                result.Status = ResultEnum.Fail;
            }
            return result;
        }
    }
}
