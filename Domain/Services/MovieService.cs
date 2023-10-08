namespace Domain.Services;

public class MovieService : BaseService, IMovieService
{
    public Task<IMethodResponse<MovieDto>> GetMovieById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IMethodResponse<List<MoviePreviewDto>>> GetMoviePreviews()
    {
        throw new NotImplementedException();
    }

    public Task<IMethodResponse<int>> CreateMovie(MovieDraftDto movie)
    {
        throw new NotImplementedException();
    }
}