namespace FurnitureShop.Models
{
    public class Order
    {
        // Creating properties of the Order class
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TaxRate { get; set; }
        public decimal ShippingFee { get; set; }

        // Relations mapping
        public virtual ICollection<Customer>? Customers { get; set; }
        public virtual OrderLine? Line { get; set; }
    }
}
