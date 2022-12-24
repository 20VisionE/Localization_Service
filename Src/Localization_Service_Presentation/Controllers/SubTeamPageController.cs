


namespace Localization_Service_Presentation.Controllers;

public class SubTeamPageController : ApiControllerBase.ApiControllerBase
{
    [HttpGet("GetSubTeamPageContent")]
    public async Task<ActionResult<GetSubEmployeesPageContentDto>> GetSubTeamEmployeesPageContentAsync([FromQuery] GetAllSubEmployeesPageResourceContentQuery dto, CancellationToken cancellationToken)
          => Ok(await Mediator.Send(dto, cancellationToken));
}
