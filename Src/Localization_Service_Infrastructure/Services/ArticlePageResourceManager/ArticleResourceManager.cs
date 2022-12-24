namespace Localization_Service_Infrastructure.Services.ArticlePageResourceManager;
public class ArticleResourceManager : IArticleResourceManager
{
    private readonly IStringLocalizer<Localization_Service_Domain.ResourcesFile.ArticlePage.ArticlePage> stringLocalizer;

    public ArticleResourceManager(IStringLocalizer<ArticlePage> stringLocalizer)
    {
        this.stringLocalizer = stringLocalizer;
    }

    public async Task<GetArticlePageContentDto> GetArticleContentAsync()
    {
        var reuslt = await Task.FromResult(new GetArticlePageContentDto
        {
            Tilte = stringLocalizer.GetString(nameof(GetArticlePageContentDto.Tilte)).Value,
        });
        return reuslt;
    }
}
