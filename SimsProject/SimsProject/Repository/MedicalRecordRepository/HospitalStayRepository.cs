/***********************************************************************
 * Module:  HospitalStayRepository.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.HospitalStayRepository
 ***********************************************************************/

using Model.Employee;
using Model.MedicalRecord;
using Model.User;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Repository.MedicalRecordRepository
{
   public class HospitalStayRepository : GenericRepository<HospitalStay>, IHospitalStayRepository
    {

        public HospitalStayRepository(String filePath) : base(filePath) { }
       
      
      public List<HospitalStay> GetByPatient(Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public List<HospitalStay> GetByDoctor(Doctor doctor)
      {
         // TODO: implement
         return null;
      }
   
      private String path;
   
   }
}