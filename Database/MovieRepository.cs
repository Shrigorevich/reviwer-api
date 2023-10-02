using Domain;
using Microsoft.Extensions.Configuration;

namespace Database;

public class MovieRepository : BaseRepository, IMovieRepository
{
    public MovieRepository(IConfiguration configuration) : base(configuration)
    {
        
    }


    public Task<int> Create(MovieDraftDto movie)
    {
        using var conn = Connection();
        
    }

    public Task<Movie> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Movie>> Get()
    {
        throw new NotImplementedException();
    }
}