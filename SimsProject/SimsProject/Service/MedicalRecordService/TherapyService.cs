/***********************************************************************
 * Module:  TherapyService.cs
 * Purpose: Definition of the Class Service.ExaminationService.TherapyService
 ***********************************************************************/

using Model.Examination;
using Model.User;
using SimsProject.Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Service.MedicalRecordService
{
   public class TherapyService
   {
      public Therapy AddTherapy(Therapy therapy)
      {
         // TODO: implement
         return null;
      }
      
      public Therapy EditTherapy(Therapy therapy)
      {
         // TODO: implement
         return null;
      }
      
      public Therapy GetTherapyById(int id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Therapy> GetTherapyByPatient(Patient patient)
      {
         // TODO: implement
         return null;
      }
   
      public ITherapyRepository itherapyRepository;
   
   }
}