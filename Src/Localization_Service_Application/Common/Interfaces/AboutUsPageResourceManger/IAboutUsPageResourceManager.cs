using Localization_Service_Application.Common.Models.Dtos.AboutUs;

namespace Localization_Service_Application.Common.Interfaces.AboutUsPageResourceManger;

public interface IAboutUsPageResourceManager
{
    Task<GetAboutUsContentDto> GetAboutUsPageContenetAsync();
}
