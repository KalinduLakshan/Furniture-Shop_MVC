namespace FurnitureShop.Models
{
    public class Product
    {
        // Creating properties of the Product class
        public int ProductId { get; set; }
        public string? ProductType { get; set; }
        public string? MaterialName { get; set;}
        public string? ProductColor { get; set;}
        public string? ProductInventory { get; set;}

        // Relations mapping
        public virtual ICollection<Customer>? Customers { get;set; }
        public virtual ICollection<ProductLine>? ProductLines { get;set; }
        public virtual OrderLine? OrderLine { get;set; }
    }
}
