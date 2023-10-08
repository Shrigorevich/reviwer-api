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
        var sql = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email);";

        object[] parameters =
        {
            new { }
        };
        var id = await conn.QuerySingleAsync<int>(sql, parameters);
        return id;
    }

    public async Task<Movie> Get(Guid id)
    {
        await using var conn = Connection();
        var movie = await conn.QuerySingleAsync<Movie>("");
        return movie;
    }

    public async Task<List<Movie>> Get()
    {
        throw new NotImplementedException();
    }
}