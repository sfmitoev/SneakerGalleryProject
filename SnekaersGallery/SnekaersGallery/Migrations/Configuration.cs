using SnekaersGallery.Data;

namespace SnekaersGallery.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<SnekaersGallery.Data.GalleryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SnekaersGallery.Data.GalleryDbContext";
        }

        protected override void Seed(GalleryDbContext context)
        {
            if (context.Sneakers.Any())
            {
                return;
            }

            var user = context.Users.FirstOrDefault();

            if (user == null)
            {
                return;
            }

            context.Sneakers.Add(new Sneaker
            {
                Brand = "Adidas",
                Model = "Yeezy 350 Boost",
                Size = 44,
                Color = "Pirate Black",
                ImageUrl ="https://www.flightclub.com/media/catalog/product/cache/1/image/800x570/9df78eab33525d08d6e5fb8d27136e95/a/d/adidas-yeezy-boost-350-pirblk-pirblk-pirblk-201122_1.jpg",
                OwnerId = user.Id
            });

            context.Sneakers.Add(new Sneaker
            {
                Brand = "Nike",
                Model = "Air Max 97",
                Size = 44,
                Color = "Silver",
                ImageUrl = "https://www.flightclub.com/media/catalog/product/cache/1/image/800x570/9df78eab33525d08d6e5fb8d27136e95/8/0/800076_1.jpg",
                OwnerId = user.Id
            });

            context.Sneakers.Add(new Sneaker
            {
                Brand = "Adidas",
                Model = "NMD",
                Size = 44,
                Color = "Blue/Red",
                ImageUrl = "https://www.flightclub.com/media/catalog/product/cache/1/image/800x570/9df78eab33525d08d6e5fb8d27136e95/6/3/63611743010-adidas-nmd-runner-pk-black-white-rd-blu-201194_1.jpg",
                OwnerId = user.Id
            });

            context.Sneakers.Add(new Sneaker
            {
                Brand = "Adidas",
                Model = "Yeezy Boost 750",
                Size = 44,
                Color = "Triple Black",
                ImageUrl = "https://www.flightclub.com/media/catalog/product/cache/1/image/800x570/9df78eab33525d08d6e5fb8d27136e95/a/d/adidas-yeezy-750-boost-cblack-cblack-cblack-201169_1.jpg",
                OwnerId = user.Id
            });

           
        }
    }
}

