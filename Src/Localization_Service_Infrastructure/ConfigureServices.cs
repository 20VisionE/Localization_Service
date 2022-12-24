namespace Localization_Service_Infrastructure;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IHomePageResourceManager, HomePageContenetManager>();
        services.AddTransient<IEmployeesResourceManager, EmployeesResourceManager>();
        return services;
    }
}
