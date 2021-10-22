using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class PatientViewModel
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string Email { get; set; }


        public List<PatientDrugViewModel> PatientDrugList { get; set; }
    }
}
