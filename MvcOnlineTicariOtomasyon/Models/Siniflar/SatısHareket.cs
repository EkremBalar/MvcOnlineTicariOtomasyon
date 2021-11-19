using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class SatısHareket
    {[Key]
        public int SatisId { get; set; }
        public DateTime Tarih { get; set; }

      

        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public Urun Urun { get; set; }
        public Cariler Cariler { get; set; }
        public Personel Personel { get; set; }
    }
}