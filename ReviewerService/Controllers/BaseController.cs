using Domain;
using Microsoft.AspNetCore.Mvc;

namespace ReviewerService.Controllers;

public class BaseController : ControllerBase
{

    protected ActionResult CreateActionResult<T>(IMethodResponse<T> methodResponse)
    {
        if (methodResponse.Error == null)
        {
            return StatusCode(201, methodResponse.Data);
        }
        else
        {
            return StatusCode(400, methodResponse.Error);
        }
    }
}