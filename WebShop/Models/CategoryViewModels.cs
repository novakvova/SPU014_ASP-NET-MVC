using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class CategoryCreateViewModel
    {
        [Display(Name = "Назва")]
        public string Name { get; set; }
    }
    public class CategoryItemViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Назва")]
        public string Name { get; set; }
    }
}
