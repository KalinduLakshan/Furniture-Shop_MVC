namespace FurnitureShop.Models
{
    public class Customer
    {
        // Creating properties of the Customer class
        public int CustomerId { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Street { get; set; }
        public string? ZipCode { get; set; }

        // Relations mapping
        public virtual Order? Orders { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
   }
}
