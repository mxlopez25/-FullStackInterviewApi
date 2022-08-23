namespace WebService.Models.Entities {
    public class EProduct {
        public EProduct () {
            Products = new List<Product>();
        }

        public EProduct(Product product) {
            Products = new List<Product>();
            Products.Add(product);
        }

        public EProduct(List<Product> products) {
            Products = new List<Product>();
            Products.AddRange(products);
        }

        public List<Product> Products { get; set; }
    }
}