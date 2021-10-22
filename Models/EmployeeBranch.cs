using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class EmployeeBranch
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
