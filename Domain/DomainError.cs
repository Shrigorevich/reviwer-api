namespace Domain;

public class DomainError : IDomainError
{
    public string Code { get; set; }
    public string Message { get; set; }
}