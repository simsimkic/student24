/***********************************************************************
 * Module:  Dokument.cs
 * Purpose: Definition of the Class Pregled.Dokument
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.Examination
{
   public class Document:Entity
   {
      public Model.Employee.Doctor issuer;
   
      private String text;
      private Boolean issued;
      private String type;
      private int id;
   
   }
}