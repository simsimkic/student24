/***********************************************************************
 * Module:  DrugControllerDecorator.cs
 * Purpose: Definition of the Class Controller.Decorator.DrugControllerDecorator
 ***********************************************************************/

using Model.Examination;
using System;
using System.Collections.Generic;

namespace Controller.DrugController
{
   public abstract class DrugControllerDecorator
   {
      public abstract List<Drug> GetAllDrugs();
      
      public abstract Model.Examination.Drug GetById(int id);
      
      public abstract List<Drug> GetDrugsForValidation(String type);
   
      public IDrugController iDrugController;
   
   }
}