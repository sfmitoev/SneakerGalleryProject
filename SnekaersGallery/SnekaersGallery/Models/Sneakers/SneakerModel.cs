 

using SnekaersGallery.Infrastructure;

namespace SnekaersGallery.Models.Sneakers
{
    using System.ComponentModel.DataAnnotations;
    public class SneakerModel
    {
        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        

        public string Color { get; set; }

        [Required]
        [Display(Name="Image Url")]
        [ImageUrl] 
        public string ImageUrl { get; set; }

    }
}