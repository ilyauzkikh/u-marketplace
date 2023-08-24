namespace Users.Domain.Base;

public abstract class AggregateRoot : Entity
{
    public bool IsAggregateRoot => true;
}