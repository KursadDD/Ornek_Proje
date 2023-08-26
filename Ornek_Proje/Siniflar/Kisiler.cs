using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ornek_Proje.Siniflar
{
    public class Kisiler
    {
        [Key]
        public int KisiID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string Ad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Soyad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Mail { get; set; }
    }
}