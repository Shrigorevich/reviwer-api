namespace Domain;

public class ArtworkDraftDto
{
    public int CategoryId { get; set; }
    public int SubCategoryId { get; set; }
    public List<int> Geners { get; set; }
    public List<TranslationDto> Name { get; set; }
    public List<TranslationDto> Description { get; set; }
}