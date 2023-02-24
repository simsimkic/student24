/***********************************************************************
 * Module:  Article.cs
 * Purpose: Definition of the Class Model.Blog.Article
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.Blog
{
   public class Article : Content
    {
      public Blog blog;
      public Model.Employee.Doctor author;
   
      private String title;
      private int id;
      private String category;
   
   }
}