using Domain;

namespace Database;

public interface IMovieRepository
{
    Task<int> Create(MovieDraftDto movie);
    Task<Movie> Get(Guid id);
    Task<List<Movie>> Get();
}