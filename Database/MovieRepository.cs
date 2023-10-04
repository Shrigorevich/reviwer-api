using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;

namespace Database;

public class MovieRepository : BaseRepository, IMovieRepository
{
    public MovieRepository(IConfiguration configuration) : base(configuration)
    {
        
    }


    public async Task<int> Create(MovieDraftDto movie)
    {
        await using var conn = Connection();
        var id = await conn.QuerySingleAsync<int>("");
        return id;
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