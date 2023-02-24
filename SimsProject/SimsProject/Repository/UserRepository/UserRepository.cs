/***********************************************************************
 * Module:  UserRepository.cs
 * Purpose: Definition of the Class Service.UserService.UserRepository
 ***********************************************************************/

using Model.User;
using SimsProject.helpers;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class UserRepository : GenericRepository<User>, IUserRepository
   {
      
      public UserRepository(String filePath) : base(filePath){}

      XmlReaderWriter rw = new XmlReaderWriter();
     
      public User getUserByUsername(String username)
      {
            List<User> users = getAll();
            foreach(var user in users)
            {
                if (username.Equals(user.userName))
                {
                    return user;
                }
            }
            return null;
      }
        public User getUserByJmbg(String jmbg)
        {
            List<User> users = getAll();
            foreach (User user in users)
            {
                if (jmbg.Equals(user.jmbg))
                {
                    return user;
                }
            }

            return null;
        }

        public Boolean saveCurrentUser(User user)
        {
            rw.SerializeObject<User>(user,path);
            return true;
        }
        

        private string path="../../Fajlovi/korisnik.xml";

    }
}