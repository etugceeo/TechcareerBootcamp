using System.ComponentModel.DataAnnotations;
namespace FormsApp.Models
{
    //[Bind("Name","Price")] for bindin only data of Name and Price
    public class Product
    {
        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Ürün adı gerekli")]
        [StringLength(100)]
        [Display(Name = "Adı")]
        public string Name { get; set; } = string.Empty;//this property nullable same ?
        [Required]
        [Range(0, 100000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }
        [Display(Name = "Resim")]
        public string Image { get; set; } = string.Empty;//if we get data of Image from form, data of ımage must be full
        public bool IsActive { get; set; }
        [Display(Name = "Category")]
        //[BindNever] this attribute is not for binding data of CategoryId
        [Required]
        public int? CategoryId { get; set; }
    }
}