

namespace Localization_Service_Infrastructure;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IHomePageResourceManager, HomePageContenetManager>();
        services.AddTransient<IContactUsPageResourceManager, ContactUsPageResourceManager>();
        services.AddTransient<IEmployeesResourceManager, EmployeesResourceManager>();
        services.AddTransient<IArticleResourceManager, ArticleResourceManager>();
        services.AddTransient<IAboutUsPageResourceManager, AboutUsPageResourceManager>();
        return services;
    }
}
