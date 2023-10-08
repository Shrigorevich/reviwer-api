using Domain;
using Microsoft.AspNetCore.Mvc;

namespace ReviewerService.Controllers;

public class BaseController : ControllerBase
{

    protected ActionResult CreateActionResult<T>(IMethodResponse<T> response)
    {
        return response.Code switch
        {
            ResponseCode.Success => (response.Data == null ? StatusCode(200) : StatusCode(200, response.Data)),
            ResponseCode.Created => (response.Data == null ? StatusCode(201) : StatusCode(201, response.Data)),
            ResponseCode.BadRequest => StatusCode(401, response.Error),
            ResponseCode.InternalError => StatusCode(500, response.Error),
            _ => throw new NotImplementedException($"Http response for code = {response.Code} not implemented")
        };
    }
}