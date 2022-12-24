namespace Localization_Service_Application.Common.Interfaces.EmployeesPageResourceManager;

public interface IEmployeesResourceManager
{
    Task<GetEmployeesPageContentDto> GetEmployeesPageContentAsync();
}
