/***********************************************************************
 * Module:  IDrugController.cs
 * Purpose: Definition of the Interface Controller.Decorator.IDrugController
 ***********************************************************************/

using Model.Examination;
using System;
using System.Collections.Generic;

namespace Controller.DrugController
{
   public interface IDrugController
   {
      List<Drug> GetAllDrugs();
      Model.Examination.Drug GetById(int id);
      List<Drug> GetDrugsForValidation(String type);
   }
}