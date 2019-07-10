using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCampWeb.Models.Entities;
using NetCampWeb.Models.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCampWeb.Controllers
{
  //  [Route("ogrenci")]
    public class OgrenciController : Controller
    {
        OgrenciServisi servis;
        public OgrenciController(OgrenciServisi _servis)
        {
            servis=_servis;
        }
        // GET: /<controller>/
        //[Route("liste_verisi")]
        public IActionResult List()
        {
            //OgrenciServisi services = new OgrenciServisi();
            
            return View(servis.GetLİst());  //BURAYA DEBUG KOYDUK.
        }
        
        public IActionResult Insert() //Bu get olacak. URL den post işlemi atamazsınız. Get olucak. 

        {
            return View(new Ogrenci());  //View'ını vermezsek default olarak inserte gider.

        }
        [HttpPost]
        public IActionResult Insert(Ogrenci model) //Bu get olacak. URL den post işlemi atamazsınız. Get olucak. 
            
        {
            if (!ModelState.IsValid) //BİRDE BURAYA DEBUG KOYDUK.
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    
                    {
                        ViewBag.Error = error.ErrorMessage;
                    }

                }
                return View(model);
            }
            else
            {
                model = servis.Insert(model);
                return RedirectToAction("List"); //Otomatikman list actionu bulup oraya gidecek. 
            }
           

        }
        public IActionResult Delete(long id)
        {
            var sonuc = servis.Delete(id);
            return RedirectToAction("List");
        }
        //Action üzerinde tanımla yaparken aynı isme sahip diğer actionlarda etkilenir. 
        //[Route("ogrenci/ogrenci-guncelle/{ogrenciId}")]
      public IActionResult Update(long id)
        {
            return View(servis.Get(id));
        }
    
             [HttpPost]
        public IActionResult Update(Ogrenci model) //Bu get olacak. URL den post işlemi atamazsınız. Get olucak. 
            
        {
            if (!ModelState.IsValid) //BİRDE BURAYA DEBUG KOYDUK.
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    
                    {
                        ViewBag.Error = error.ErrorMessage;
                    }

                }
                return View(model);
            }
            else
            {
                model = servis.Insert(model);
                return RedirectToAction("List"); //Otomatikman list actionu bulup oraya gidecek. 
            }
           

        }
                
        }
    }


//turgutmectaze/netcamp
