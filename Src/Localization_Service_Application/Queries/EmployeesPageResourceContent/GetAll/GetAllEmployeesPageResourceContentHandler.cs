namespace Localization_Service_Application.Queries.EmployeesPageResourceContent.GetAll;

public class GetAllEmployeesPageResourceContentHandler : IRequestHandler<GetAllEmployeesPageResourceContentQuery, GetEmployeesPageContentDto>
{
    private readonly IEmployeesResourceManager employeesResourceManager;

    public GetAllEmployeesPageResourceContentHandler(IEmployeesResourceManager employeesResourceManager)
    {
        this.employeesResourceManager = employeesResourceManager;
    }

    public async Task<GetEmployeesPageContentDto> Handle(GetAllEmployeesPageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await employeesResourceManager.GetEmployeesPageContentAsync();
    }
}
