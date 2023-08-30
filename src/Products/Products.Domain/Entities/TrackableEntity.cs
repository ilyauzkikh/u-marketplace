namespace Products.Domain.Entities;

public abstract class TrackableEntity : Entity
{
    public TrackableEntity(Guid? creatorId = null)
    {
        CreatedAtUtc = DateTime.UtcNow;
        CreatedByUserId = creatorId;
    }

    public DateTime CreatedAtUtc { get; private set; }
    public Guid? CreatedByUserId { get; private set; }
    public DateTime? EditedAtUtc { get; private set; }
    public Guid? EditedByUserId { get; private set; }

    public void UpdateEditedStatus()
    {
        EditedAtUtc = DateTime.UtcNow;
    }
}