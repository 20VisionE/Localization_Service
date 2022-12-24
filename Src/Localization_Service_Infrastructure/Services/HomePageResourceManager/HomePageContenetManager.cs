using Localization_Service_Application.Common.Models.Dtos.HomePage;

namespace Localization_Service_Infrastructure.Services.ResourceFileManager;
public class HomePageContenetManager : IHomePageResourceManager
{
    private readonly IStringLocalizer<Localization_Service_Domain.ResourcesFile.HomePage.HomePage> stringLocalizer;
    public HomePageContenetManager(IStringLocalizer<Localization_Service_Domain.ResourcesFile.HomePage.HomePage> stringLocalizer)
    {
        this.stringLocalizer = stringLocalizer;
    }

    public async Task<GetHomePageContentDto> GetHomePageContentAsync()
    {
        return await Task.FromResult(new GetHomePageContentDto
        {
            TitleName = stringLocalizer[nameof(GetHomePageContentDto.TitleName)],
        });
    }
}
