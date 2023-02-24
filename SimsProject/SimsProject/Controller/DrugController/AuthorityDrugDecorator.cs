/***********************************************************************
 * Module:  AuthorityDrugDecorator.cs
 * Purpose: Definition of the Class Controller.Decorator.AuthorityDrugDecorator
 ***********************************************************************/

using Model.Examination;
using System;
using System.Collections.Generic;

namespace Controller.DrugController
{
   public class AuthorityDrugDecorator : DrugControllerDecorator
   {
      public Model.Examination.Drug EditDrug(Model.Examination.Drug drug)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Examination.Drug AddAlternativeDrug(Model.Examination.Drug originalDrug, Model.Examination.Drug alternativeDrug)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Examination.Drug ApproveDrug(Model.Examination.Drug drug)
      {
         // TODO: implement
         return null;
      }
      
      public Drug AddDrug(Model.Examination.Drug drug)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Examination.Drug CreateDrug(Model.Examination.Drug drug)
      {
         // TODO: implement
         return null;
      }
      
      public void SendToConfirmation(Model.Employee.Doctor doctor, Model.Examination.Drug drug)
      {
         // TODO: implement
      }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override List<Drug> GetAllDrugs()
        {
            throw new NotImplementedException();
        }

        public override Drug GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Drug> GetDrugsForValidation(String type)
        {
            throw new NotImplementedException();
        }

        public Service.DrugService.DrugService drugService;
   
   }
}