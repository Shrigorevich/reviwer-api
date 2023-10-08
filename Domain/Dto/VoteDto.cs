namespace Domain;

public class VoteDto
{
    public string UserId { get; set; }
    public Guid ArtworkId { get; set; }
    public DateOnly Date { get; set; }
        
}