namespace Localization_Service_Application.Queries.ServicesPageResourceContent.GetAll;
public class GetAllServicesPageResourceContentHandler : IRequestHandler<GetAllServicesPageResourceContentQuery, GetServicesPageContenetDto>
{
    private readonly IServicesPageResourceManager servicesPageResourceManager;

    public GetAllServicesPageResourceContentHandler(IServicesPageResourceManager servicesPageResourceManager)
    {
        this.servicesPageResourceManager = servicesPageResourceManager;
    }

    public async Task<GetServicesPageContenetDto> Handle(GetAllServicesPageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await servicesPageResourceManager.GetAllServicesPageContentAsync();
    }
}
