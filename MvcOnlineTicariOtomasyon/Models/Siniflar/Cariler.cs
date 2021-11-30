using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int CariId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30,ErrorMessage ="En fazla 30 karakter Girebilirsiniz!")]
        public string CariSoyad { get; set; }
       
        [Column(TypeName = "Varchar")]
        [StringLength(13,ErrorMessage = "En fazla 13 karakter Girebilirsiniz!")]
        public string CariSehir { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter Girebilirsiniz!")]
        public string CariMail { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter Girebilirsiniz!")]
        public string CariSifre { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }

    }
}