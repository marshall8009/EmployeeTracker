using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ConnectionHelper
    {
        public static string GetConnectionString()
        {
            //connect to the database at tafe
            //return "Data Source=.;Initial Catalog=EmployeeTrackingDB;Integrated Security=True";
            //connect to the database at home
            return @"Data Source=IP-C0A84B23\MSSQLSERVER01;Initial Catalog=EmployeeTrackingDB;Integrated Security=True";
        }
    }
}
