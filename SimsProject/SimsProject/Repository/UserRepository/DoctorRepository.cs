/***********************************************************************
 * Module:  DoctorRepository.cs
 * Purpose: Definition of the Class Service.UserService.DoctorRepository
 ***********************************************************************/

using Model.Employee;
using SimsProject.helpers;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
      public DoctorRepository(String filePath) : base(filePath){}
      public List<Doctor> GetDoctorsByDate(DateTime startDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetDoctorBySpecility(Specialty speciality)
      {
         // TODO: implement
         return null;
      }
      
      public Doctor GetDoctor(String username)
      {
         // TODO: implement
         return null;
      }
     
      private string path;
   
   }
}