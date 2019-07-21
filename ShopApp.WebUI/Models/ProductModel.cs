using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        //[Required]
        //[StringLength(60, MinimumLength = 2, ErrorMessage = "Ürün ismi minimum 2 karakter ve maksimum 60 karakter olmalıdır.")]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2, ErrorMessage = "Ürün ismi minimum 2 karakter ve maksimum 250 karakter olmalıdır.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Fiyat bilgisi giriniz.")]
        [Range(1,999999)]
        public decimal? Price { get; set; }

        public List<Category> SelectedCategories { get; set; }

    }
}
