

namespace Localization_Service_Application.Common.Interfaces.ServicesPageResourceManager;

public interface IServicesPageResourceManager
{
    Task<GetServicesPageContenetDto> GetAllServicesPageContentAsync();
}
