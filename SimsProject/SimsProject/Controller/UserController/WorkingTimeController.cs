/***********************************************************************
 * Module:  BusinessDayService.cs
 * Purpose: Definition of the Class Service.BusinessDayService
 ***********************************************************************/

using Model.Employee;
using Service.EmployeeService;
using System;

namespace Controller.UserController
{
   public class WorkingTimeController
   {
      public WorkingTime AddWorkingTime(WorkingTime workingTime)
      {
            workingTimeService = new WorkingTimeService();
            return workingTimeService.AddWorkingTime(workingTime);
      }
      
      public WorkingTime EditWorkingTime(WorkingTime workingTime)
      {
         // TODO: implement
         return null;
      }
   
      public WorkingTimeService workingTimeService;
   
   }
}