namespace FurnitureShop.Models
{
    public class OrderLine
    {
        // Creating properties of the OrderLine class
        public int OrderLineId { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderedQuantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Subtotal { get; set; }

        // Relations mapping
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
