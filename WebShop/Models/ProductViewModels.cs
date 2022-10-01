using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebShop.Data.Entities;
using System.Collections.Generic;
using WebShop.Models.Helpers;

namespace WebShop.Models
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }
        [Display(Name="Назва")]
        public string Name { get; set; }
        [Display(Name="Ціна")]
        public decimal Price { get; set; }
        [Display(Name = "Категорія")]
        public string Category { get; set; }
    }
    public class ProductCreateViewModel
    {
        [Display(Name = "Назва")]
        [Required(ErrorMessage ="Вказіть назву продукта")]
        public string Name { get; set; }
        [Display(Name = "Ціна")]
        [Required(ErrorMessage = "Вказіть ціну продукта")]
        public decimal Price { get; set; }
        [Display(Name = "Категорія")]
        [Required(ErrorMessage = "Вказіть категорію продукта")]
        public int CategoryId { get; set; }
        [Display(Name = "Опис")]
        public string Description { get; set; }
        public List<SelectItemViewModel> Categories { get; set; }
    }

    public class ProductEditViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Назва")]
        [Required(ErrorMessage = "Вказіть назву продукта")]
        public string Name { get; set; }
        [Display(Name = "Ціна")]
        [Required(ErrorMessage = "Вказіть ціну продукта")]
        public decimal Price { get; set; }
        [Display(Name = "Категорія")]
        [Required(ErrorMessage = "Вказіть категорію продукта")]
        public int CategoryId { get; set; }
        [Display(Name = "Опис")]
        public string Description { get; set; }
        public List<SelectItemViewModel> Categories { get; set; }
    }

    public class ProductDeleteViewModel
    {
        public int Id { get; set; }
    }
}
