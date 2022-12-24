namespace Localization_Service_Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeesPageController : ApiControllerBase.ApiControllerBase
{




    [HttpGet("GetEmployeesPageContnet")]
    public async Task<ActionResult<GetEmployeesPageContentDto>> GetEmployeesPageContentAsync([FromQuery] EmployeesPageResourceContentQuery dto, CancellationToken cancellationToken)
    {
        return await Mediator.Send(dto, cancellationToken);
    }
}
