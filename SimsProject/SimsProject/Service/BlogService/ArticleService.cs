/***********************************************************************
 * Module:  ArticleService.cs
 * Purpose: Definition of the Class Service.ArticleService
 ***********************************************************************/

using Model.Blog;
using SimsProject.Repository.BlogRepository;
using System;
using System.Collections.Generic;

namespace Service.BlogService
{
   public class ArticleService
   {
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
      
      public List<Article> GetAllArticle()
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteArticle(Article article)
      {
         // TODO: implement
      }
      
      public Article AddArticle(Article article)
      {
         // TODO: implement
         return null;
      }
   
      public IArticleRepository iarticleRepository;
   
   }
}