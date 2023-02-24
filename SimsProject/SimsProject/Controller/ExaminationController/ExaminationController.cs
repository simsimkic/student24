/***********************************************************************
 * Module:  ExaminationService.cs
 * Purpose: Definition of the Class Service.ExaminationService
 ***********************************************************************/

using Model.Examination;
using SimsProject.helpers;
using System;
using System.Collections.Generic;

namespace Controller.ExaminationController
{
   public class ExaminationController
   {
        XmlReaderWriter rw = new XmlReaderWriter();

        public List<Examination> GetAllExamination()
        {
            examinationService = new Service.ExaminationService.ExaminationService();
            return examinationService.GetAllExamination();
        }
        public String SelectPriority(String priority)
      {
         // TODO: implement
         return null;
      }

        public int getLastExaminationId()
        {
            examinationService = new Service.ExaminationService.ExaminationService();
            return examinationService.getLastExaminationId();
        }
        public Model.Examination.Examination ScheduleExamination(Model.Examination.Examination examination)
      {
            examinationService = new Service.ExaminationService.ExaminationService();
            return examinationService.ScheduleExamination(examination);
           

        }
      
      public void CancelExamination(Model.Examination.Examination examination)
      {
         // TODO: implement
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
      
      public Boolean MarkAsCompleted(Model.Examination.Examination examination)
      {
         // TODO: implement
         return false;
      }
      
      public List<Examination> GetScheduledDoctorExaminations(Model.Employee.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Examination.Examination PostponeExamination(Model.Examination.Examination examination)
      {
         // TODO: implement
         return null;
      }
   
      public Service.ExaminationService.ExaminationService examinationService;
   
   }
}