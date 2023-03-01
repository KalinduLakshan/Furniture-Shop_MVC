namespace FurnitureShop.Models
{
    public class ProductLine
    {
        // Creating properties of the ProductLine class
        public int ProductLineId { get; set; }
        public string? ProductLineName { get; set; }
        public string? SupplierName { get; set; }

        // Relations mapping
        public virtual Product? Products { get; set; }
    }
}
