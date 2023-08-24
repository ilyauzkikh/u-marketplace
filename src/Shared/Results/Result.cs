namespace Shared.Results;

public abstract class Result
{
    protected Result(ResultStatus status)
    {
        Status = status;
    }
    
    public ResultStatus Status { get; }
}