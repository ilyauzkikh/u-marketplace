namespace Products.Domain.BaseEntities;

public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; protected set; }
}