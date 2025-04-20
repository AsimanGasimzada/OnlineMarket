namespace OnlineMarket_BB104.Models.Common;
public abstract class BaseEntity
{
    public int Id { get; private init; }

    protected BaseEntity(int id)
    {
        Id = id;
    }
}
