using Domain;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace ReviewerService.Controllers;

[ApiController]
[Route("artworks")]
public class ArtworkController : BaseController
{
    
    private readonly ILogger<ArtworkController> _logger;
    private readonly IArtworkService _artworkService;
    

    public ArtworkController(ILogger<ArtworkController> logger, IArtworkService artworkService)
    {
        _logger = logger;
        _artworkService = artworkService;
    }
    
    [HttpPost]
    public async Task<ActionResult> Vote([FromBody] VoteDto vote)
    {
        var result = await _artworkService.Vote(vote);
        return CreateActionResult(result);
    }
    
    [HttpGet("previews")]
    public async Task<ActionResult> GetPreviews()
    {
        var result = await _artworkService.GetArtworkPreviews();
        return CreateActionResult(result);
    }
}