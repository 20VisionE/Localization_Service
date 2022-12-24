namespace Localization_Service_Presentation.Controllers;
public class ArticlePageController : ApiControllerBase.ApiControllerBase
{
    [HttpGet("GetArticlePageContent")]
    public async Task<ActionResult<GetArticleContentDto>> GetArticlePageContentAsync([FromQuery] GetAllArtcilePageResourceContentQuery dto, CancellationToken cancellationToken)
        => Ok(await Mediator.Send(dto, cancellationToken));
}
