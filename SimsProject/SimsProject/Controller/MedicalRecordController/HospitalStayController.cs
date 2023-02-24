/***********************************************************************
 * Module:  HospitalStayService.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.HospitalStayService
 ***********************************************************************/

using Model.MedicalRecord;
using Model.User;
using System;
using System.Collections.Generic;

namespace Controller.MedicalRecordController
{
   public class HospitalStayController
   {
      public HospitalStay AddHospitalStay(HospitalStay hospitalStay)
      {
         // TODO: implement
         return null;
      }
      
      public HospitalStay EditHospitalStay(HospitalStay hospitalStay)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteHospitalStay(HospitalStay hospitalStay)
      {
         // TODO: implement
      }
      
      public List<HospitalStay> GetByPatient(Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public List<HospitalStay> GetByDoctor(Model.Employee.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
   
      public Service.MedicalRecordService.HospitalStayService hospitalStayService;
   
   }
}