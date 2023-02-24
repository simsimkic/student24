/***********************************************************************
 * Module:  DrugController.cs
 * Purpose: Definition of the Class Controller.ExaminationController.DrugController
 ***********************************************************************/

using Model.Examination;
using System;
using System.Collections.Generic;

namespace Controller.DrugController
{
   public class DrugController : IDrugController
   {
      public Service.DrugService.DrugService drugService;

        public List<Drug> GetAllDrugs()
        {
            throw new NotImplementedException();
        }

        public Drug GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetDrugsForValidation(String type)
        {
            throw new NotImplementedException();
        }
    }
}