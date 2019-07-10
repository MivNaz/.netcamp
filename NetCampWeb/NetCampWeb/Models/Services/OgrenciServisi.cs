using NetCampWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace NetCampWeb.Models.Services
{
    public class OgrenciServisi
    {
        public OgrenciServisi()
        {
            if (GlobalData.Ogrenciler==null)
            {
                GlobalData.Ogrenciler = new List<Ogrenci>(); //Eğer için null sa boş bir öğrenci listesi oluştur dedik. 
                //Şu listeleri çok kullanacağız. Yazılımın olmazsa olmazı. 
            }
        }
        public List<Ogrenci> GetLİst()
        {
            return GlobalData.Ogrenciler;
        }
        public Ogrenci Get(long id)
        {
            return GlobalData.Ogrenciler.FirstOrDefault(q => q.Id == id); //Girdiğim id den bizim id ye eşit olan varsa onun ilkini al. First ü öbe aldık böylece ilk bulup alıyor.Performan açısından önemli. 
            
        }
        public Ogrenci Insert(Ogrenci model)
        {
            
           model.Id=DateTime.Now.Ticks;  //Ticks: Bİr rakam oluşturuyor.

            GlobalData.Ogrenciler.Add(model);
            return model;
        }
        public Ogrenci Update(Ogrenci model)
        {

            var data = GlobalData.Ogrenciler.FirstOrDefault(q => q.Id == model.Id);
            var index = GlobalData.Ogrenciler.IndexOf(data);
            GlobalData.Ogrenciler[index] = model;
            return model;

            
        }
        public bool Delete(long id)
        {
        
            var data = GlobalData.Ogrenciler.FirstOrDefault(q => q.Id ==id);
            var index = GlobalData.Ogrenciler.IndexOf(data);
            GlobalData.Ogrenciler.RemoveAt(index);
            return true;


        }

    }
}
