using OnlineMarket_BB104.Models.Common;

namespace OnlineMarket_BB104.Models;

public class Product : BaseEntity
{
    private static int _id = 1;
    public Product(string name, decimal price) : base(_id++)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Id}.  {Name}  {Price}$";
    }
}