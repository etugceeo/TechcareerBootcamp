using System.ComponentModel.DataAnnotations;
namespace BookInfoApp.Models{
    public class Product{
        [Display(Name="Urun Id")]
        public int ProductId {get; set;}
        [Display(Name="Kitap Adı")]
        public string Name {get; set;}  = string.Empty;
        [Display(Name="Ücret")]
        public decimal Price {get; set;}
        [Display(Name="Resim")]
        public string Image {get; set;} = string.Empty;
        public bool IsActive {get; set;}
        public int CategoryId {get; set;}
    }
}