namespace Domain.Services;

public interface IArtworkService
{
    /// <summary>
    /// Stores the user's rating for a specific Artwork
    /// </summary>
    /// <param name="userVote">User`s vote info</param>
    /// <returns>User rating</returns>
    Task<IMethodResponse<float>> Vote(VoteDto userVote);
}