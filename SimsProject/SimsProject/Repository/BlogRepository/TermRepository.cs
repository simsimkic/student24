/***********************************************************************
 * Module:  TermService.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.TermService
 ***********************************************************************/

using Model.Examination;
using Service.TermService;
using SimsProject.helpers;
using SimsProject.Repository.BlogRepository;
using SimsProject.Repository.GenericRepository;
using System;
using System.Collections.Generic;

namespace Repository.BlogRepository
{
   public class TermRepository : GenericRepository<Period>, ITermRepository
    {
        public TermRepository(String filePath) : base(filePath){}
       
        public List<Period> SearchTerm(String usernameDoctor, DateTime date)
        {
            List<Period> periods = new List<Period>();
            List<Period> periodList = getAll();

            foreach (var term in periodList)
            {
                if (term.usernameDoctor.Equals(usernameDoctor) && date == term.day)
                {
                    periods.Add(term);
                }
            }
            return periods;
        }


        private string path= "../../Fajlovi/slobodniTermini.xml";
   
   }
}