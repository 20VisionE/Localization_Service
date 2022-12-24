namespace Localization_Service_Presentation.Controllers;
public class ArticlePageController : ApiControllerBase.ApiControllerBase
{
    [HttpGet("GetArticlePageContent")]
    public async Task<ActionResult<GetArticlePageContentDto>> GetArticlePageContentAsync([FromQuery] GetAllArtcilePageResourceContentQuery dto, CancellationToken cancellationToken)
        => Ok(await Mediator.Send(dto, cancellationToken));
}
