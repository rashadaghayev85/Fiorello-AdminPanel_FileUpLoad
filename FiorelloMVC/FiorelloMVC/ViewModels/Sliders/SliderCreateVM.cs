using System.ComponentModel.DataAnnotations;

namespace FiorelloMVC.ViewModels.Sliders
{
    public class SliderCreateVM
    {
        [Required]
        public IFormFile Image { get; set; }
    }
}
