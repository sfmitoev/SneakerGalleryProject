using System.ComponentModel.DataAnnotations;
using SnekaersGallery.Infrastructure;

namespace SnekaersGallery.Models.Sneakers
{
    public class SneakerDetails
    {
        
        public string Brand { get; set; }

      
        public string Model { get; set; }

    

        public string Color { get; set; }
 
        public string ImageUrl { get; set; }
    }
}