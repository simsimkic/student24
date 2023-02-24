/***********************************************************************
 * Module:  GodisnjiOdmor.cs
 * Purpose: Definition of the Class Ljekar.GodisnjiOdmor
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.Employee
{
   public class Vacation:Entity
   {
      public Model.Examination.Term term;
      public Model.User.Employee employee;
   
      private Boolean approved;
      private String reasonForRejection;
      private Boolean onHold;
      private int lengthOfVacation = 30;
   
   }
}