namespace Localization_Service_Application.Queries.EmployeesPageResourceContent.GetAll;

public class EmployeesPageResourceContentHandler : IRequestHandler<EmployeesPageResourceContentQuery, GetEmployeesPageContentDto>
{
    private readonly IEmployeesResourceManager employeesResourceManager;

    public EmployeesPageResourceContentHandler(IEmployeesResourceManager employeesResourceManager)
    {
        this.employeesResourceManager = employeesResourceManager;
    }

    public async Task<GetEmployeesPageContentDto> Handle(EmployeesPageResourceContentQuery request, CancellationToken cancellationToken)
    {
        return await employeesResourceManager.GetEmployeesPageContentAsync();
    }
}
