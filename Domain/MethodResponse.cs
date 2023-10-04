namespace Domain;

public class MethodResponse<T>  : IMethodResponse<T> 
{
    public MethodResponse(T data)
    {
        Data = data;
    }

    public MethodResponse(IDomainError error)
    {
        Error = error;
    }
    public T? Data { get; set; }
    public IDomainError? Error { get; set; }
}