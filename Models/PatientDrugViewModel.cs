using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class PatientDrugViewModel
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public bool IsChecked { get; set; }
    }
}
