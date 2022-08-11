namespace WebService.Models {
    public class ProductImage {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public String FileName { get; set; }
        public String FilePath { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}