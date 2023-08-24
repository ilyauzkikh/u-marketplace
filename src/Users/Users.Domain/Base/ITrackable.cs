namespace Users.Domain.Base;

public interface ITrackable
{
    DateTime CreatedAt { get; }
    DateTime? EditedAt { get; }
}