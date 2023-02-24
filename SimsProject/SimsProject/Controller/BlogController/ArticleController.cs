/***********************************************************************
 * Module:  ArticleService.cs
 * Purpose: Definition of the Class Service.ArticleService
 ***********************************************************************/

using Model.Blog;
using System;
using System.Collections.Generic;

namespace Controller.BlogController
{
   public class ArticleController
   {
      public List<Article> GetArticleByCategory(String category)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Blog.Article GetArticle(int articleId)
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
      
      public Model.Blog.Article AddArticle(Article article)
      {
         // TODO: implement
         return null;
      }
   
      public Service.BlogService.ArticleService articleService;
   
   }
}