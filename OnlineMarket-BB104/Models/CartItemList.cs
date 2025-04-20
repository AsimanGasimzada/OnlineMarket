namespace OnlineMarket_BB104.Models;
public class CartItemList
{
    private List<CartItem> Cart { get; set; } = [];

    public CartItem this[int index] { get => Cart[index]; set => Cart[index] = value; }


    public void Add(CartItem cartItem)
    {
        Cart.Add(cartItem);
    }

    public void Remove(CartItem cartItem)
    {
        Cart.Remove(cartItem);
    }

    public bool IsExist(int id)
    {
        var isExist = Cart.Any(x => x.Id == id);

        return isExist;
    }

    public CartItem? GetById(int id)
    {
        var cartItem = Cart.FirstOrDefault(x => x.Id == id);
        return cartItem;
    }

    public List<CartItem> GetAll()
    {
        return Cart;
    }

    public CartItem? GetByProductId(int productId)
    {
        var cartItem = Cart.FirstOrDefault(x => x.Product.Id == productId);
        return cartItem;
    }
}