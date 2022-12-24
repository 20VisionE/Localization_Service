namespace Localization_Service_Infrastructure.Services.SubEmployeePageResourceManager;

public class SubEmployeePageResourceManager : ISubEmployeePageResourceManager
{
    private readonly IStringLocalizer<Localization_Service_Domain.ResourcesFile.SubTeamPage.SubEmployeesPage> localizer;

    public SubEmployeePageResourceManager(IStringLocalizer<SubEmployeesPage> localizer)
    {
        this.localizer = localizer;
    }

    public async Task<GetSubEmployeesPageContentDto> GetSubEmployeePageResourceContentAsync()
    {
        return await Task.FromResult(new GetSubEmployeesPageContentDto
        {
            Title = localizer.GetString(nameof(GetSubEmployeesPageContentDto.Title)).Value,
        });
    }
}
