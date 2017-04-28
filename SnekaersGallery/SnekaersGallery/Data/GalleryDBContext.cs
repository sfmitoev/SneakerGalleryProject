using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SnekaersGallery.Data
{
    public class GalleryDbContext : IdentityDbContext<User>
    {
        public GalleryDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


        public virtual IDbSet<Sneaker> Sneakers { get; set;  }

        public static GalleryDbContext Create()
        {
            return new GalleryDbContext();
        }
    }
}