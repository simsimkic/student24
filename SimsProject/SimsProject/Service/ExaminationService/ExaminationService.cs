/***********************************************************************
 * Module:  ExaminationService.cs
 * Purpose: Definition of the Class Service.ExaminationService
 ***********************************************************************/

using Model.Examination;
using SimsProject.helpers;
using System;
using System.Collections.Generic;
using Repository.ExaminationRepository;
using SimsProject.Repository.ExaminationRepository;
using Model.Employee;
using SimsProject.Repository.UserRepository;

namespace Service.ExaminationService
{
   public class ExaminationService
   {
        XmlReaderWriter rw = new XmlReaderWriter();

        public List<Examination> GetAllExamination()
        {
            iexaminationRepository = new ExaminationRepository("../../Fajlovi/pregledi.xml");
            return iexaminationRepository.getAll();
        }
        public Examination PostponeExamination(Examination examination)
      {
         // TODO: implement
         return null;
      }

        public int getLastExaminationId()
        {
            int num = 0;
            iexaminationRepository = new ExaminationRepository("../../Fajlovi/pregledi.xml");

            List<Examination>  examinationList = iexaminationRepository.getAll();
            foreach (var r in examinationList)
            {
                num = r.Id;
            }
            return num;
        }
        public Examination ScheduleExamination(Examination examination)
      {
            iexaminationRepository = new ExaminationRepository("../../Fajlovi/pregledi.xml");
            return iexaminationRepository.save(examination);
            
        }
      
      public void CancelExamination(Examination examination)
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
      
      public List<Examination> GetScheduledDoctorExaminations(Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public String SelectPriority(String priority)
      {
         // TODO: implement
         return null;
      }
   
      public IExaminationRepository iexaminationRepository;
      public IDoctorRepository idoctorRepository;

      public Service.TermService.TermService termService;
      public Service.UserService.NotificationService notificationService;

    }
}