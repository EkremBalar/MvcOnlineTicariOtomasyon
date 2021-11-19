using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PersonelAdı { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string personelSoyadı { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(230)]
        public string PersonelGorsel { get; set; }
        public ICollection<SatısHareket> SatısHarekets { get; set; }
        public Departman Departman { get; set; }
    }
}