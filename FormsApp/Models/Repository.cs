namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();
        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });
            _products.Add(new Product { ProductId = 1, Name = "IPhone 14", Price = 5000, IsActive = true, Image = "1.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "IPhone 15", Price = 6000, IsActive = true, Image = "2.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, Name = "IPhone 16", Price = 7000, IsActive = true, Image = "3.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 4, Name = "IPhone 17", Price = 8000, IsActive = true, Image = "4.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 5, Name = "Macbook Air", Price = 9000, IsActive = true, Image = "5.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, Name = "Macbook Pro", Price = 10000, IsActive = true, Image = "6.jpg", CategoryId = 2 });
        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}