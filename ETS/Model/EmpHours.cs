using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmpHours
    {
        //fields and porps
        public int EmpHoursId { get; set; }
        public int EmpID { get; set; }
        public DateTime WorkDate { get; set; }
        public decimal Hours { get; set; }
    }
}
