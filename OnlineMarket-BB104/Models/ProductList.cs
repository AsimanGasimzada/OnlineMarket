namespace OnlineMarket_BB104.Models;

public class ProductList
{
    private List<Product> Products { get; set; } = [];


    public Product this[int index] { get => Products[index]; set => Products[index] = value; }


    public void Add(Product product)
    {
        Products.Add(product);
    }

    public void Remove(Product product)
    {
        Products.Remove(product);
    }

    public bool IsExist(int id)
    {
        var isExist = Products.Any(x => x.Id == id);
        return isExist;
    }

    public Product? GetById(int id)
    {
        var product = Products.FirstOrDefault(x => x.Id == id);
        return product;
    }

    public List<Product> GetAll()
    {
        return Products;
    }
}
