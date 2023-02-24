/***********************************************************************
 * Module:  TermService.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.TermService
 ***********************************************************************/

using Model.Examination;
using Service.TermService;
using SimsProject.helpers;
using System;
using System.Collections.Generic;

namespace Controller.BlogController
{
   public class TermController
   {
        XmlReaderWriter rw = new XmlReaderWriter();
        public List<Period> searchTerm(String usernameDoctor, DateTime date)
        {
            termService = new Service.TermService.TermService();
            return termService.SearchTerm(usernameDoctor, date);
            
        }
   
      public Period addTerm(Period period)
      {
            termService = new Service.TermService.TermService();
            return termService.addTerm(period);

        }
      public Service.TermService.TermService termService;
   
   }
}