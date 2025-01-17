﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitness.Models
{
    public class Curs
    {
        public int ID { get; set; }
        [Display(Name = "Denumire Curs Practicat")]
        public string DenumireCurs { get; set; }
        public string Dificultate { get; set; }
        public ICollection<Abonamente> Abonamente { get; set; }
    }
}
