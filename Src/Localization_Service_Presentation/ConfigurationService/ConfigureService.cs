namespace Localization_Service_Presentation.ConfigurationService;
public static class ConfigureService
{
    public static IServiceCollection AddLayersConfigureService(this IServiceCollection services)
    {




        services.AddPresistenceService();
        services.AddInfrastructure();
        services.AddApplicationService();

        return services;
    }
}
