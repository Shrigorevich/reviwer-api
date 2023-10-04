namespace Domain.Services;

public interface IMovieService
{
    /// <summary>
    /// Gets whole info about movie by ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<IMethodResponse<MovieDto>> GetMovieById(Guid id);

    /// <summary>
    /// Gets list of movies with preview info
    /// </summary>
    /// <returns>List of previews</returns>
    Task<IMethodResponse<List<MoviePreviewDto>>> GetMoviePreviews();

    /// <summary>
    /// Creates new movie
    /// </summary>
    /// <param name="movie">Movie draft info</param>
    /// <returns>ID of created movie</returns>
    Task<IMethodResponse<int>> CreateMovie(MovieDraftDto movie);
}