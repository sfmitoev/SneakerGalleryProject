

using System.Linq;
using Microsoft.AspNet.Identity;
using SnekaersGallery.Data;
using SnekaersGallery.Models.Sneakers;

namespace SnekaersGallery.Controllers
{
    using System.Web.Mvc;
    public class SneakersController : Controller
    {
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(SneakerModel sneakermodel)
         {
            if (this.ModelState.IsValid)
            {
                var ownerId = this.User.Identity.GetUserId();

                var sneaker = new Sneaker
                {
                    Brand = sneakermodel.Brand,
                    Model=sneakermodel.Model,
                    Color = sneakermodel.Color,
                    ImageUrl = sneakermodel.ImageUrl,
                    OwnerId=ownerId
                };

                var db=new GalleryDbContext();

                db.Sneakers.Add(sneaker);
                db.SaveChanges();

                return RedirectToAction("Details", new { id=sneaker.Id});
            }

            return View(sneakermodel);
        }

        public ActionResult Details(int id)
        {
            var db=new GalleryDbContext();

            var sneaker = db.Sneakers
                .Where(c => c.Id==id)
                .Select(c => new SneakerDetails
                {
                    Brand = c.Brand,
                    Model = c.Model,
                    Color = c.Color,
                    ImageUrl = c.ImageUrl
                })
                .FirstOrDefault();
            if (sneaker == null)
            {
                return HttpNotFound();
            }

            return View(sneaker);
        }

        public ActionResult All(int page=1)
        {
            var db = new GalleryDbContext();

            var pageSize = 6;

            var sneaker = db.Sneakers
                .OrderByDescending(c=>c.Id)
                .Skip((page-1)*pageSize)
                .Take(pageSize)
                .Select(c => new AllSneakerModel
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Color = c.Color,
                    ImageUrl = c.ImageUrl
                })
                .ToList();

            ViewBag.CurrentPage = page;

            return View(sneaker);
        }

        public ActionResult SearchByBrand(string brand)
        {
            var db=new GalleryDbContext();

            var sneaker = db.Sneakers
                .Where(c => c.Brand.Equals(brand))
                .Select(c => new AllSneakerModel()
                {
                    Brand = c.Brand,
                    Model = c.Model,
                    Color = c.Color,
                    ImageUrl = c.ImageUrl
                })
                .ToList();

            return View(sneaker);
        }

    }
}