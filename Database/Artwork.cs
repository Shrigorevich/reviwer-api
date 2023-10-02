namespace Database;

public class Artwork
{
    public int CategoryId { get; set; }
    public int SubCategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid Id { get; set; }
    public List<int> Geners { get; set; }
}