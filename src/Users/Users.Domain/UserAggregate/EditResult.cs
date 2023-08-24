using Shared.Results;

namespace Users.Domain.UserAggregate;

public class EditResult : Result<User>
{
    private EditResult(bool isSuccess) : base(isSuccess)
    {
    }

    public static EditResult Success(User user)
    {
        return new EditResult(true) { Entity = user };
    }
}