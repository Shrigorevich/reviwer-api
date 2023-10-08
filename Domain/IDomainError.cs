namespace Domain;

public interface IDomainError
{
    string Code { get; set; }
    string Message { get; set; }
}