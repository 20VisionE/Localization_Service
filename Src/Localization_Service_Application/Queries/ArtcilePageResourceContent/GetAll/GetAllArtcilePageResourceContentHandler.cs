namespace Localization_Service_Application.Queries.ArtcilePageResourceContent.GetAll;

public class GetAllArtcilePageResourceContentHandler : IRequestHandler<GetAllArtcilePageResourceContentQuery, GetArticleContentDto>
{
    private readonly IArticleResourceManager articleResourceManager;

    public GetAllArtcilePageResourceContentHandler(IArticleResourceManager articleResourceManager)
    {
        this.articleResourceManager = articleResourceManager;
    }

    public async Task<GetArticleContentDto> Handle(GetAllArtcilePageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await articleResourceManager.GetArticleContentAsync();
    }
}
