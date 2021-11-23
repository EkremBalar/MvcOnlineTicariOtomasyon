﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Departman
        
    {
        [Key]
        public int DepartmanId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter Girebilirsiniz!")]
        public string DepartmanAdı { get; set; }
        public bool Durum { get; set; }


        public ICollection<Personel> Personels { get; set; }
    }
}