namespace Domain;

public class MethodResponse<T>  : IMethodResponse<T> 
{
    public MethodResponse(T data, ResponseCode code)
    {
        Data = data;
        Code = code;
    }

    public MethodResponse(IDomainError error, ResponseCode code)
    {
        Error = error;
        Code = code;
    }
    public T? Data { get; set; }
    public IDomainError? Error { get; set; }
    public ResponseCode Code { get; set; }
}