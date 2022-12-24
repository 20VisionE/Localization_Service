namespace Localization_Service_Infrastructure.Services.ArticlePageResourceManager;
public class ArticleResourceManager : IArticleResourceManager
{
    private readonly IStringLocalizer<Localization_Service_Domain.ResourcesFile.ArticlePage.ArticlePage> stringLocalizer;

    public ArticleResourceManager(IStringLocalizer<ArticlePage> stringLocalizer)
    {
        this.stringLocalizer = stringLocalizer;
    }

    public async Task<GetArticleContentDto> GetArticleContentAsync()
    {
        var reuslt = await Task.FromResult(new GetArticleContentDto
        {
            Tilte = stringLocalizer.GetString(nameof(GetArticleContentDto.Tilte)).Value,
        });
        return reuslt;
    }
}
