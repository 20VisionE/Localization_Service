namespace Localization_Service_Presentation.Controllers;
public class AboutUsPageController : ApiControllerBase.ApiControllerBase
{

    [HttpGet("GetAboutUsContentPage")]
    public async Task<ActionResult<GetAboutUsContentDto>> GetAboutUsContentPageAsycn([FromQuery] GetAboutUsPageResourceContentQuery dto, CancellationToken cancellationToken)
       => Ok(await Mediator.Send(dto, cancellationToken));
}
