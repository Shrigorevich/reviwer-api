using Domain;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace ReviewerService.Controllers;

[ApiController]
[Route("movie")]
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
    public async Task<ActionResult<MovieDto>> GetMovieById(Guid id)
    {
        var result = await _movieService.GetMovieById(id);
        return CreateActionResult(result);
    }
}