using OnlineMarket_BB104.Exceptions;
using OnlineMarket_BB104.Models.Common;

namespace OnlineMarket_BB104.Models;
public class OnlineMarket : BaseEntity
{
    public static int _id = 1;
    public string Name { get; set; }
    public CartItemList CartItemList { get; set; }
    public ProductList ProductList { get; set; }

    public OnlineMarket(string name) : base(_id++)
    {
        Name = name;
        CartItemList = new();
        ProductList = new();
    }


    public void AddProduct(Product product)
    {
        var isExist = ProductList.IsExist(product.Id);

        if (isExist)
            throw new AlreadyExistException();


        ProductList.Add(product);
    }

    public void ShowProducts()
    {
        foreach (var product in ProductList.GetAll())
            Console.WriteLine(product);
    }

    public void RemoveProduct(int id)
    {
        var product = ProductList.GetById(id);

        if (product is null)
            throw new NotFoundException("Product not found");

        var cartItem = CartItemList.GetByProductId(id);

        if(cartItem is { })
            CartItemList.Remove(cartItem);

            ProductList.Remove(product);
    }

    public void AddToCart(int productId, int quantity)
    {
        var product = ProductList.GetById(productId);

        if (product is null)
            throw new NotFoundException("Product not found");

        if (quantity <= 0)
            quantity = 1;


        var existCartItem = CartItemList.GetByProductId(productId);

        if(existCartItem is { }) //existItem is not null || existItem is object || existItem is not default
        {
            existCartItem.Quantity += quantity;
            return;
        }

        CartItem newCartItem = new(product, quantity);

        CartItemList.Add(newCartItem);
    }

    public void ShowCart()
    {
        foreach (var cartItem in CartItemList.GetAll())
            Console.WriteLine(cartItem);

        Console.WriteLine();

        decimal sum = CartItemList.GetAll().Sum(x => x.Product.Price * x.Quantity);

        Console.WriteLine($"Total: {sum}");
    }
}
