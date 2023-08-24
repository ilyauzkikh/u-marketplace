using Shared.Results;
using Users.Domain.Base;

namespace Users.Domain.UserAggregate;

public class User : AggregateRoot, ITrackable
{
    public User(string firstName,
        string lastName,
        DateTime bornAt)
    {
        FirstName = firstName;
        LastName = lastName;
        BornAt = bornAt;
    }
    
    public DateTime CreatedAt { get; } = DateTime.UtcNow;
    public DateTime? EditedAt { get; private set; }
    
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime BornAt { get; private set; }

    public ResultStatus Edit(string firstName,
        string lastName,
        DateTime bornAt)
    {
        FirstName = firstName;
        LastName = lastName;
        BornAt = bornAt;
        EditedAt = DateTime.UtcNow;

        return ResultStatus.Success;
    }
}