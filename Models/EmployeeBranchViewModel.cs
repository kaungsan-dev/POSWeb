using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class EmployeeBranchViewModel
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public bool IsChecked { get; set; }
    }
}
