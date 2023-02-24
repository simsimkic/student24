/***********************************************************************
 * Module:  Obavjestenje.cs
 * Purpose: Definition of the Class Pacijent.Obavjestenje
 ***********************************************************************/

using Model.Blog;
using SimsProject.Model.Entity;
using System;

namespace Model.User
{
   public class Notification:Entity
   {
      public Content content;
   
      private String title;
      private int id;
      private Boolean read;
   
   }
}