/***********************************************************************
 * Module:  ExaminationRepository.cs
 * Purpose: Definition of the Class Service.ExaminationService.ExaminationRepository
 ***********************************************************************/

using Model.Employee;
using Model.Examination;
using SimsProject.helpers;
using SimsProject.Repository.ExaminationRepository;
using SimsProject.Repository.GenericRepository;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationRepository
{
   public class ExaminationRepository : GenericRepository<Examination>, IExaminationRepository
    {
        public ExaminationRepository(String filePath) : base(filePath)
        {

        }

       
        public List<Examination> GetScheduledPatientExaminations(int recordMedicalId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Examination> GetFinishedPatientExamination(int recordMedicalId)
      {
         // TODO: implement
         return null;
      }
      
      public List<Examination> GetScheduledDoctorExaminations(Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public List<Examination> GetByDate(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
     
   
      private string path;
   
   }
}