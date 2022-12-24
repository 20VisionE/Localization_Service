namespace Localization_Service_Infrastructure.Services.ServicesPageResourceManager;
public class ServicesPageResourceManager : IServicesPageResourceManager
{
    private readonly IStringLocalizer<Localization_Service_Domain.ResourcesFile.ServicesPage.ServicesPage> localizer;

    public ServicesPageResourceManager(IStringLocalizer<ServicesPage> localizer)
    {
        this.localizer = localizer;
    }

    public async Task<GetServicesPageContenetDto> GetAllServicesPageContentAsync()
    {
        return await Task.FromResult(new GetServicesPageContenetDto
        {
            Title = localizer.GetString(nameof(GetServicesPageContenetDto.Title)).Value,
        });
    }
}
