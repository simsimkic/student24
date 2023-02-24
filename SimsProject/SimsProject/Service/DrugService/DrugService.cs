/***********************************************************************
 * Module:  DrugService.cs
 * Purpose: Definition of the Class Service.DrugService
 ***********************************************************************/

using Model.Employee;
using Model.Examination;
using SimsProject.Repository.ExaminationRepository;
using SimsProject.Repository.RoomRepository;
using System;
using System.Collections.Generic;

namespace Service.DrugService
{
   public class DrugService
   {
      public void SendToConfirmation(Doctor doctor, Drug drug)
      {
         // TODO: implement
      }
      
      public Drug AddDrug(Drug drug)
      {
         // TODO: implement
         return null;
      }
      
      public Drug EditDrug(Drug drug)
      {
         // TODO: implement
         return null;
      }
      
      public Drug AddAlternativeDrug(Drug originalDrug, Drug alternativeDrug)
      {
         // TODO: implement
         return null;
      }
      
      public Drug ApproveDrug(Drug drug)
      {
         // TODO: implement
         return null;
      }
      
      public Drug CreateDrug(Drug drug)
      {
         // TODO: implement
         return null;
      }
      
      public List<Drug> GetAllDrugs()
      {
         // TODO: implement
         return null;
      }
      
      public Drug GetById(int id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Drug> GetDrugsForValidation(String type)
      {
         // TODO: implement
         return null;
      }
   
      public IWarehouseRepository iwarehouseRepository;
      public IDrugRepository idrugRepository;
   
   }
}