using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class PatientDrugs
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int DrugId { get; set; }
        public Drugs Drugs { get; set; }
    }
}
