using OnlineMarket_BB104.Models.Common;

namespace OnlineMarket_BB104.Models;
public class CartItem : BaseEntity
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    private static int _id = 1;
    public CartItem(Product product, int quantity) : base(_id++)
    {
        Product = product;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{Id}.   {Product.Name}  Price:{Product.Price}   Count:{Quantity}  Total:{Quantity * Product.Price}";
    }
}
