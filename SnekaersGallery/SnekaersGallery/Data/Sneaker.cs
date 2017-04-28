using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SnekaersGallery.Data
{
    public class Sneaker
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        //In EU size
        public int Size { get; set; }

        public string Color { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string OwnerId { get; set; }

        public virtual User Owner { get; set; }
    }
}