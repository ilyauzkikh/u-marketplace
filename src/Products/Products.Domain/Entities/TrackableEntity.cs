namespace Products.Domain.Entities;

public abstract class TrackableEntity : Entity
{
    public DateTime CreatedAt { get; set; }
    public DateTime? EditedAt { get; set; }
}