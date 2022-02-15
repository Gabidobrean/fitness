using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitness.Models
{
    public class Antrenor
    {

        public int ID { get; set; }
        [Display(Name = "Nume Antrenor")]
        public string NumeAntrenor { get; set; }
        [Display(Name = "Prenume Antrenor")]
        public string PrenumeAntrenor { get; set; }
        public string Ziua { get; set; }
        public string Ora { get; set; }
    }
}
