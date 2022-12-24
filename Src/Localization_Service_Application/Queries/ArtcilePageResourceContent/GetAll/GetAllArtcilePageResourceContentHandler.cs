namespace Localization_Service_Application.Queries.ArtcilePageResourceContent.GetAll;

public class GetAllArtcilePageResourceContentHandler : IRequestHandler<GetAllArtcilePageResourceContentQuery, GetArticlePageContentDto>
{
    private readonly IArticleResourceManager articleResourceManager;

    public GetAllArtcilePageResourceContentHandler(IArticleResourceManager articleResourceManager)
    {
        this.articleResourceManager = articleResourceManager;
    }

    public async Task<GetArticlePageContentDto> Handle(GetAllArtcilePageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await articleResourceManager.GetArticleContentAsync();
    }
}
