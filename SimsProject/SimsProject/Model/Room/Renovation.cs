/***********************************************************************
 * Module:  Renoviranje.cs
 * Purpose: Definition of the Class Pacijent.Renoviranje
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.Room
{
   public class Renovation:Entity
   {
      public Room room;
      public Model.Examination.Term term;
   
      private String description;
      private Boolean completed = false;
   
   }
}