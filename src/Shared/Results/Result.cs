namespace Shared.Results;

public abstract class Result<T> where T: class
{
    protected Result(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }
    
    public bool IsSuccess { get; private set; }
    public T Entity { get; protected set; }
}