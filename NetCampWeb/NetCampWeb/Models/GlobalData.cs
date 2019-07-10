using NetCampWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCampWeb.Models
{
    public static class GlobalData
    {
        public static List<Ogrenci> Ogrenciler { get; set; } //Generic list. Boşsa boştur doluysa doludur. Kapasite vermezsiniz.
    }
}// Generic yapılar örn : benzeri kurulan yapılarımız var generic'te bir servis tanımlayıp dinamik bir tip veriyoruz. Bir daha servis oluştururken generic servis oluşturup sen öğrenci için hazırla diyoruz. Yerni bir eklemede Servislerin instancesini alıp veriye tip veriyoruz. 
