using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ornek_Proje.Siniflar
{
    public class Bolum
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
    }
}