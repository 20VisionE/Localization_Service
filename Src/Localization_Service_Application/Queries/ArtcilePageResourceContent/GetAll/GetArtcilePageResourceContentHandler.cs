namespace Localization_Service_Application.Queries.ArtcilePageResourceContent.GetAll;

public class GetArtcilePageResourceContentHandler : IRequestHandler<GetArtcilePageResourceContentQuery, GetArticleContentDto>
{
    private readonly IArticleResourceManager articleResourceManager;

    public GetArtcilePageResourceContentHandler(IArticleResourceManager articleResourceManager)
    {
        this.articleResourceManager = articleResourceManager;
    }

    public async Task<GetArticleContentDto> Handle(GetArtcilePageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await articleResourceManager.GetArticleContentAsync();
    }
}
