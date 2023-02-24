/***********************************************************************
 * Module:  SecretaryRepository.cs
 * Purpose: Definition of the Class Service.UserService.SecretaryRepository
 ***********************************************************************/

using Model.Employee;
using SimsProject.helpers;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class SecretaryRepository : GenericRepository<Secretary>, ISecretaryRepository
    {
        public SecretaryRepository(String filePath) : base(filePath) { }

        public Secretary GetSecretary(String username)
        {
           // TODO: implement
           return null;
        }
      
       private string path;
   
   }
}