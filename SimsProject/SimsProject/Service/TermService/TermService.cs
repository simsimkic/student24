/***********************************************************************
 * Module:  TermService.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.TermService
 ***********************************************************************/

using Model.Examination;
using Model.User;
using SimsProject.helpers;
using System;
using System.Collections.Generic;
using Repository.BlogRepository;
using SimsProject.Repository.BlogRepository;
using SimsProject.Repository.UserRepository;
using SimsProject.Repository.RoomRepository;
using SimsProject.Repository.MedicalRecordRepository;

namespace Service.TermService
{
   public class TermService
   {
        XmlReaderWriter rw = new XmlReaderWriter();
        public List<Period> SearchTerm(String usernameDoctor, DateTime date)
        {
           
            itermRepository = new TermRepository("../../Fajlovi/slobodniTermini.xml");
            return itermRepository.SearchTerm(usernameDoctor, date);
           
        }

        public Period addTerm(Period period)
        {
            itermRepository = new TermRepository("../../Fajlovi/slobodniTermini.xml");
            return itermRepository.save(period);

        }
      public IRenvationRepository irenvationRepository;
      public ITherapyRepository itherapyRepository;
      public IDoctorRepository idoctorRepository;
      public IBedroomRepository ibedroomRepository;
      public IHallRepository ihallRepository;

      public ITermRepository itermRepository;
   
   }
}