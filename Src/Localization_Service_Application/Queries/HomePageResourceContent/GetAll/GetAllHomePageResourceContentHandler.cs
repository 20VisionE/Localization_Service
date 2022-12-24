using Localization_Service_Application.Common.Models.Dtos.HomePage;

namespace Localization_Service_Application.Queries.HomePageResourceContent.GetAll;
public class GetAllHomePageResourceContentHandler : IRequestHandler<GetAllHomePageResourceContentQuery, GetHomePageContentDto>
{
    private readonly IHomePageResourceManager homePageContenetManager;

    public GetAllHomePageResourceContentHandler(IHomePageResourceManager homePageContenetManager)
    {
        this.homePageContenetManager = homePageContenetManager;
    }

    public async Task<GetHomePageContentDto> Handle(GetAllHomePageResourceContentQuery request, CancellationToken cancellationToken)
     =>    await homePageContenetManager.GetHomePageContentAsync();

}
