using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SnekaersGallery.Data;
using SnekaersGallery.Models.Sneakers;

namespace SnekaersGallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db=new GalleryDbContext();

            var sneakers = db.Sneakers
                .OrderByDescending(c => c.Id)
                .Take(6)
                .Select(c => new IndexSneaker
                {
                    Id=c.Id,
                    ImageUrl = c.ImageUrl
                })
                .ToList(); 


            return View(sneakers);
        }
    }
}