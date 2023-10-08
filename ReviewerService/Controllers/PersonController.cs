using Domain;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace ReviewerService.Controllers;

[ApiController]
[Route("persons")]
public class PersonController : BaseController
{
    
    private readonly ILogger<PersonController> _logger;
    private readonly IPersonService _personService;
    

    public PersonController(ILogger<PersonController> logger, IPersonService personService)
    {
        _logger = logger;
        _personService = personService;
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult> GetPersonById(int id)
    {
        var result = await _personService.GetPersonById(id);
        return CreateActionResult(result);
    }
    
    [HttpGet]
    public async Task<ActionResult> GetPreviews([FromQuery] string search)
    {
        var result = await _personService.GetPersons();
        return CreateActionResult(result);
    }
    
    [HttpPost]
    public async Task<ActionResult> CreatePerson([FromBody] PersonDraftDto person)
    {
        var result = await _personService.CreatePerson(person);
        return CreateActionResult(result);
    }
}