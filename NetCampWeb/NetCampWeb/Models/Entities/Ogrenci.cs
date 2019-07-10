using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCampWeb.Models.Entities
{
    public class Ogrenci
    {
        
        public long Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Kullanıcı adı maksimum 10 karakter olabilir.")]
        [MinLength(3, ErrorMessage = "Kullanıcı adı minimum 3 karakter olabilir.")]
        public string kullanici_adi { get; set; }
        [Required] //boş geçilemez. 
        public string Adi { get; set; }
        [Required]
        public string Soyadi { get; set; }
        public int Yasi { get; set; }
    }
}
