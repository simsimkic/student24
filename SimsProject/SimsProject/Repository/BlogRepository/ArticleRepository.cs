/***********************************************************************
 * Module:  ArticleRepository.cs
 * Purpose: Definition of the Class Service.BlogService.ArticleRepository
 ***********************************************************************/

using Model.Blog;
using SimsProject.Repository.BlogRepository;
using SimsProject.Repository.GenericRepository;
using System;
using System.Collections.Generic;

namespace Repository.BlogRepository
{
   public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
      public ArticleRepository(String filePath) : base(filePath) { }
      
      public List<Article> GetArticleByCategory(String category)
      {
         // TODO: implement
         return null;
      }
      
      public Article GetArticle(int articleId)
      {
         // TODO: implement
         return null;
      }
     
      private String path;
   
   }
}