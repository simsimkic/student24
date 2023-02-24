/***********************************************************************
 * Module:  TermDTO.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.TermDTO
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Service.TermService
{
   public class Period : Entity
   {
        public DateTime day { get; set; }
        public String startTime { get; set; }
        public String endTime { get; set; }
        public String usernameDoctor { get; set; }

    }
}