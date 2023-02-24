/***********************************************************************
 * Module:  MenagerRepository.cs
 * Purpose: Definition of the Class Service.UserService.MenagerRepository
 ***********************************************************************/

using Model.Employee;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class MenagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public MenagerRepository(String filePath) : base(filePath) { }

        public Manager GetMenager(String username)
        {
         // TODO: implement
         return null;
        }
     
        private String path;
   
   }
}