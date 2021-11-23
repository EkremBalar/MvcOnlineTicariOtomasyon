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
        [StringLength(30, ErrorMessage = "En fazla 30 karakter Girebilirsiniz!")]
        public string PersonelAdı { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter Girebilirsiniz!")]
        public string personelSoyadı { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(230, ErrorMessage = "En fazla 230 karakter Girebilirsiniz!")]
        public string PersonelGorsel { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public int Departmanid { get; set; }
        public virtual Departman Departman { get; set; }
    }
}