namespace Localization_Service_Application.Common.Interfaces.SubEmployeePageResourceManager;

public interface ISubEmployeePageResourceManager
{
    Task<GetSubEmployeesPageContentDto> GetSubEmployeePageResourceContentAsync();
}
