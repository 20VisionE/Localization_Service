namespace Localization_Service_Application.Common.Interfaces.ContactUsPageResourceManager;

public interface IContactUsPageResourceManager
{
    Task<GetContactUsPageContentDto> GetContactUsPageContentAsync();
}
