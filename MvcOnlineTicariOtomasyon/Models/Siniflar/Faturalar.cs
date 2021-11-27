using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Faturalar
    {[Key]
        public int FaturaId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1, ErrorMessage = "En fazla 1 karakter Girebilirsiniz!")]
        public string FaturaSeriNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6, ErrorMessage = "En fazla 6 karakter Girebilirsiniz!")]
        public string FaturaSıraNo { get; set; }

        public DateTime Tarih { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter Girebilirsiniz!")]
        public string VergiDairesi { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(5)]
        public string  Saat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter Girebilirsiniz!")]


        public string TeslimEden    { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter Girebilirsiniz!")]
        public string TeslimAlan { get; set; }

        public decimal Toplam { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }

    }
}