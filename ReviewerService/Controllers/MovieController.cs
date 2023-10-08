using Domain;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace ReviewerService.Controllers;

[ApiController]
[Route("movies")]
public class MovieController : BaseController
{
    
    private readonly ILogger<MovieController> _logger;
    private readonly IMovieService _movieService;
    

    public MovieController(ILogger<MovieController> logger, IMovieService movieService)
    {
        _logger = logger;
        _movieService = movieService;
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult> GetMovieById(Guid id)
    {
        var result = await _movieService.GetMovieById(id);
        return CreateActionResult(result);
    }
    
    [HttpGet("previews")]
    public async Task<ActionResult> GetPreviews()
    {
        var result = await _movieService.GetMoviePreviews();
        return CreateActionResult(result);
    }
    
    [HttpPost]
    public async Task<ActionResult> CreateMovie([FromBody] MovieDraftDto movie)
    {
        var result = await _movieService.CreateMovie(movie);
        return CreateActionResult(result);
    }

    
}