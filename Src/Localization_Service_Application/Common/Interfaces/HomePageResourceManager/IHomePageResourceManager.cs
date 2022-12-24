namespace Localization_Service_Application.Common.Interfaces.ResourcesFile;

public interface IHomePageResourceManager
{
    Task<GetHomePageContentDto> GetHomePageContentAsync();
}
