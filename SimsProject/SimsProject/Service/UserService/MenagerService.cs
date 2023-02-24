/***********************************************************************
 * Module:  MenagerService.cs
 * Purpose: Definition of the Class Service.UserService.MenagerService
 ***********************************************************************/

using Model.Employee;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
   public class MenagerService
   {
      public List<Manager> GetAllMenager()
      {
         // TODO: impl
         return null;
      }
      
      public Manager GetMenager(String username)
      {
         // TODO: implement
         return null;
      }
   
      public IManagerRepository imanagerRepository;
      public IUserRepository iuserRepository;
   
   }
}