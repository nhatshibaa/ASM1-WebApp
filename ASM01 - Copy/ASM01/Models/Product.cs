namespace ASM01.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Unit { get; set; }
        public int Status { get; set; }
    }
}
