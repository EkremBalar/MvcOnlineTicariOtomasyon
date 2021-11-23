using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Kategori

    {
        [Key]
        public int KategoriId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter Girebilirsiniz!")]
        public string KategoriAdı { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}