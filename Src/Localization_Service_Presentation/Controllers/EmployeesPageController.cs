namespace Localization_Service_Presentation.Controllers;

public class EmployeesPageController : ApiControllerBase.ApiControllerBase
{




    [HttpGet("GetEmployeesPageContnet")]
    public async Task<ActionResult<GetEmployeesPageContentDto>> GetEmployeesPageContentAsync([FromQuery] GetAllEmployeesPageResourceContentQuery dto, CancellationToken cancellationToken)
     =>Ok(await Mediator.Send(dto, cancellationToken));
}
