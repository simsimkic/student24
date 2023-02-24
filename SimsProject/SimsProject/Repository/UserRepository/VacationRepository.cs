/***********************************************************************
 * Module:  VacationRepository.cs
 * Purpose: Definition of the Class Service.EmployeeService.VacationRepository
 ***********************************************************************/

using Model.Employee;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class VacationRepository : GenericRepository<Vacation>, IVacationRepository
    {

      public VacationRepository(String filePath) : base(filePath) { }
      public List<Vacation> GetVacationOnHold(Boolean onHold)
      {
         // TODO: implement
         return null;
      }
      
      public List<Vacation> GetApprovedVacation(Boolean approved)
      {
         // TODO: implement
         return null;
      }
      
      private String path;
   
   }
}