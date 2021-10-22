using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }


        public List<EmployeeBranchViewModel> BranchList { get; set; }
    }
}
