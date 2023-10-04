namespace Domain;

public interface IMethodResponse<T>
{
    T? Data { get; set; }
    
    IDomainError? Error { get; set; }
}