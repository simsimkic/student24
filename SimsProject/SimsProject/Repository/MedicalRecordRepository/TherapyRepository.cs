/***********************************************************************
 * Module:  TherapyRepository.cs
 * Purpose: Definition of the Class Service.ExaminationService.TherapyRepository
 ***********************************************************************/

using Model.Examination;
using Model.User;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Repository.MedicalRecordRepository
{
   public class TherapyRepository : GenericRepository<Therapy>, ITherapyRepository
   {

      public TherapyRepository(String filePath) : base(filePath) { }
       
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
   
      private String path;
   
   }
}