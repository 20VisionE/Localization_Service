namespace Localization_Service_Presentation.Controllers;
public class ServicesPageController : ApiControllerBase.ApiControllerBase
{
    [HttpGet("GetServicesPageContent")]
    public async Task<ActionResult<GetServicesPageContenetDto>> GetServicesPageContentAsync([FromQuery]GetAllServicesPageResourceContentQuery dto, CancellationToken cancellationToken)
         => Ok(await Mediator.Send(dto, cancellationToken));
}
