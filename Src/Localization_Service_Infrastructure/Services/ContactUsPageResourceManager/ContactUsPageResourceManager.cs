namespace Localization_Service_Infrastructure.Services.ContactUsPageResourceManager;
public class ContactUsPageResourceManager : IContactUsPageResourceManager
{
    private readonly IStringLocalizer<Localization_Service_Domain.ResourcesFile.ContactUs.ContactUsPage> stringLocalizer;

    public ContactUsPageResourceManager(IStringLocalizer<ContactUsPage> stringLocalizer)
    {
        this.stringLocalizer = stringLocalizer;
    }

    public async Task<GetContactUsPageContentDto> GetContactUsPageContentAsync()
    {
        return await Task.FromResult(new GetContactUsPageContentDto
        {
            Title = stringLocalizer.GetString(nameof(GetContactUsPageContentDto.Title)).Value,

        });
    }
}
