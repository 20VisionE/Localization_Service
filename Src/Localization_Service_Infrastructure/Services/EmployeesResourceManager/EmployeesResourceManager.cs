namespace Localization_Service_Infrastructure.Services.EmployeesResourceManager;
public class EmployeesResourceManager : IEmployeesResourceManager
{
    private readonly IStringLocalizer<Localization_Service_Domain.ResourcesFile.EmployeePage.EmployeePage> localizer;

    public EmployeesResourceManager(IStringLocalizer<EmployeePage> localizer)
    {
        this.localizer = localizer;
    }

    public async Task<GetEmployeesPageContentDto> GetEmployeesPageContentAsync()
    {
        return await Task.FromResult(new GetEmployeesPageContentDto
        {
            Title = localizer.GetString(nameof(GetEmployeesPageContentDto.Title)).Value,
        });
    }
}
