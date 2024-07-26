namespace BookInfoApp.Models{
    public class ProductViewModel{
        public List<Product> Products {get; set;} = null!;
        public string? SelectedCategory {get; set;}
        public List<Category> Categories {get; set;} = null!;
    }
}