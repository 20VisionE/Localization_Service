

namespace Localization_Service_Application.Queries.ContactUsResourceContent.GetAll;

public class GetContactUsPageResourceContentHandler : IRequestHandler<GetContactUsPageResourceContentQuery, GetContactUsPageContentDto>
{
    private readonly IContactUsPageResourceManager contactUsPageResourceManager;

    public GetContactUsPageResourceContentHandler(IContactUsPageResourceManager contactUsPageResourceManager)
    {
        this.contactUsPageResourceManager = contactUsPageResourceManager;
    }

    public async Task<GetContactUsPageContentDto> Handle(GetContactUsPageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return  await contactUsPageResourceManager.GetContactUsPageContentAsync();
    }
}
