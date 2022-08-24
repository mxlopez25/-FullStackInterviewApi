using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Models {
    public class Product {
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Sku { get; set; }
        
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; } = 1.0m;

        public bool isValid() {
            return !string.IsNullOrEmpty(Name);
        }
    }
}