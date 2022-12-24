namespace Localization_Service_Presentation.Controllers;

public class HomePageController : ApiControllerBase.ApiControllerBase
{
    public HomePageController()
    {
    }

    [HttpGet("GetHomePageContent")]
    public async Task<ActionResult<GetHomePageContentDto>> GetHomePageContentAsync([FromQuery]GetAllHomePageResourceContentQuery dto, CancellationToken cancellationToken)
     => Ok(await Mediator.Send(dto, cancellationToken));
}
