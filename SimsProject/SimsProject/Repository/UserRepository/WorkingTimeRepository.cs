/***********************************************************************
 * Module:  WorkingTimeRepository.cs
 * Purpose: Definition of the Class Repository.UserRepository.WorkingTimeRepository
 ***********************************************************************/

using Model.Employee;
using SimsProject.helpers;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class WorkingTimeRepository : GenericRepository<WorkingTime>, IWorkingTimeRepository
    {
      public WorkingTimeRepository(String filePath) : base(filePath){}

      
      public WorkingTime GetWorkingTimeByUser(String username)
      {
         // TODO: implement
         return null;
      }
      
     
      private string path;
   
   }
}