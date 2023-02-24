/***********************************************************************
 * Module:  VacationService.cs
 * Purpose: Definition of the Class Service.EmployeeService.VacationService
 ***********************************************************************/

using Model.Employee;
using Model.Examination;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Service.EmployeeService
{
   public class VacationService
   {
      public Vacation AddVacation(Vacation vacation)
      {
         // TODO: implement
         return null;
      }
      
      public Vacation EditVacation(Vacation vacation)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteVacation(Vacation vacation)
      {
         // TODO: implement
      }
      
      public void SendRequest(Term term, String username)
      {
         // TODO: implement
      }
      
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
   
      public IVacationRepository ivacationRepository;
      
      
     
   }
}