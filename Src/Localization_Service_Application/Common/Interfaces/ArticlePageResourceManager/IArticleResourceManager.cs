﻿namespace Localization_Service_Application.Common.Interfaces.ArticlePageResourceManager;

public interface IArticleResourceManager
{
    Task<GetArticlePageContentDto> GetArticleContentAsync();
}
