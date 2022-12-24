namespace Localization_Service_Application.Queries.AboutUsPageResourceContent.GetAll;
public class GetAllAboutUsPageResourceContentHandler : IRequestHandler<GetAllAboutUsPageResourceContentQuery, GetAboutUsContentDto>
{
    private readonly IAboutUsPageResourceManager resourceManager;

    public GetAllAboutUsPageResourceContentHandler(IAboutUsPageResourceManager resourceManager)
    {
        this.resourceManager = resourceManager;
    }

    public async Task<GetAboutUsContentDto> Handle(GetAllAboutUsPageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await resourceManager.GetAboutUsPageContenetAsync();
    }
}
