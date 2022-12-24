

namespace Localization_Service_Infrastructure.Services.AboutUsPageResourceManager;
public class AboutUsPageResourceManager : IAboutUsPageResourceManager
{
    private readonly IStringLocalizer<Localization_Service_Domain.ResourcesFile.AboutUsPage.AboutUsPage> localizer;

    public AboutUsPageResourceManager(IStringLocalizer<AboutUsPage> localizer)
    {
        this.localizer = localizer;
    }

    public async Task<GetAboutUsContentDto> GetAboutUsPageContenetAsync()
    {
        return await Task.FromResult(new GetAboutUsContentDto
        {
            Title = localizer.GetString(nameof(GetAboutUsContentDto.Title)).Value,
        });
    }
}
