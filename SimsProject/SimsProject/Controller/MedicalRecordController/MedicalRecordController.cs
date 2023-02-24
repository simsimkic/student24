/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.MedicalRecordService
 ***********************************************************************/

using System;

namespace Controller.MedicalRecordController
{
   public class MedicalRecordController
   {
      
      public Model.MedicalRecord.MedicalRecord CreateRecord(Model.User.Patient patient)
      {
            medicalRecordService = new Service.MedicalRecordService.MedicalRecordService();
            return medicalRecordService.CreateRecord(patient);

      }
      
      public Model.MedicalRecord.MedicalRecord EditRecord(Model.MedicalRecord.MedicalRecord record)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteRecord(Model.MedicalRecord.MedicalRecord record)
      {
         // TODO: implement
      }
      
      public Model.MedicalRecord.MedicalRecord GetRecord(String username)
      {
         // TODO: implement
         return null;
      }
   
      public Service.MedicalRecordService.MedicalRecordService medicalRecordService;

    }
}