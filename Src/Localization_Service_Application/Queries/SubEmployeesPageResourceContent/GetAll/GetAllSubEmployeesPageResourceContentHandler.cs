

namespace Localization_Service_Application.Queries.SubEmployeesPageResourceContent.GetAll;

public class GetAllSubEmployeesPageResourceContentHandler : IRequestHandler<GetAllSubEmployeesPageResourceContentQuery, GetSubEmployeesPageContentDto>
{
    private readonly ISubEmployeePageResourceManager resourceManager;

    public GetAllSubEmployeesPageResourceContentHandler(ISubEmployeePageResourceManager resourceManager)
    {
        this.resourceManager = resourceManager;
    }

    public async Task<GetSubEmployeesPageContentDto> Handle(GetAllSubEmployeesPageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await resourceManager.GetSubEmployeePageResourceContentAsync();
    }
}
