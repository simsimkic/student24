/***********************************************************************
 * Module:  BusinessDayService.cs
 * Purpose: Definition of the Class Service.BusinessDayService
 ***********************************************************************/

using System;
using Repository.UserRepository;
using Service.UserService;
using SimsProject.Repository.UserRepository;

namespace Service.EmployeeService
{
   public class WorkingTimeService
   {
      public Model.Employee.WorkingTime AddWorkingTime(Model.Employee.WorkingTime workingTime)
      {
           iworkingTimeRepository = new WorkingTimeRepository("../../Fajlovi/radnoVrijeme.xml");
            return iworkingTimeRepository.save(workingTime);
      }
      
      public Model.Employee.WorkingTime EditWorkingTime(Model.Employee.WorkingTime workingTime)
      {
         // TODO: implement
         return null;
      }
   
      public SecretaryService secretaryService;
      public DoctorService doctorService;

      public IWorkingTimeRepository iworkingTimeRepository;
   
   }
}