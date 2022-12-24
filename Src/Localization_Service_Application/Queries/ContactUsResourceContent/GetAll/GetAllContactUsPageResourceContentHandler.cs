

namespace Localization_Service_Application.Queries.ContactUsResourceContent.GetAll;

public class GetAllContactUsPageResourceContentHandler : IRequestHandler<GetAllContactUsPageResourceContentQuery, GetContactUsPageContentDto>
{
    private readonly IContactUsPageResourceManager contactUsPageResourceManager;

    public GetAllContactUsPageResourceContentHandler(IContactUsPageResourceManager contactUsPageResourceManager)
    {
        this.contactUsPageResourceManager = contactUsPageResourceManager;
    }

    public async Task<GetContactUsPageContentDto> Handle(GetAllContactUsPageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return  await contactUsPageResourceManager.GetContactUsPageContentAsync();
    }
}
