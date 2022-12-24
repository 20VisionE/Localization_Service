namespace Localization_Service_Application.Queries.AboutUsPageResourceContent.GetAll;
public class GetAboutUsPageResourceContentHandler : IRequestHandler<GetAboutUsPageResourceContentQuery, GetAboutUsContentDto>
{
    private readonly IAboutUsPageResourceManager resourceManager;

    public GetAboutUsPageResourceContentHandler(IAboutUsPageResourceManager resourceManager)
    {
        this.resourceManager = resourceManager;
    }

    public async Task<GetAboutUsContentDto> Handle(GetAboutUsPageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await resourceManager.GetAboutUsPageContenetAsync();
    }
}
