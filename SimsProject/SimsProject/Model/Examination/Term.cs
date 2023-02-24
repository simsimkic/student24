/***********************************************************************
 * Module:  Termin.cs
 * Purpose: Definition of the Class Pregled.Termin
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.Examination
{
   public class Term : Entity
   {
      public DateTime start { get; set; }
      public DateTime end { get; set; }
   
   }
}