using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VIS_WEB.Models
{
    public class MaturitaForm
    {
        [Required]
        public string jmeno { get; set; }
        [Required]
        public string prijmeni { get; set; }
    }
}
