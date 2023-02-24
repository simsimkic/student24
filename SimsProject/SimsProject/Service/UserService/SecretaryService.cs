/***********************************************************************
 * Module:  SecretaryService.cs
 * Purpose: Definition of the Class Service.UserService.SecretaryService
 ***********************************************************************/

using Model.Employee;
using System;
using System.Collections.Generic;
using Repository.UserRepository;
using SimsProject.Repository.UserRepository;

namespace Service.UserService
{
   public class SecretaryService
   {
        private int MinLengthPass = 5;
        public Secretary RegisterSecretary(Secretary secreatry)
      {
            if (IsJMBGValid(secreatry.jmbg) && IsUsernameValid(secreatry.userName) && IsPasswordValid(secreatry.password))
            {
                isecretaryRepository = new SecretaryRepository("../../Fajlovi/sekretari.xml");
                return isecretaryRepository.save(secreatry);
            }

            return null;
        }

        public List<Secretary> GetAllSecretary()
        {
            List<Secretary>  sekretari = new List<Secretary>();
            isecretaryRepository = new SecretaryRepository("../../Fajlovi/sekretari.xml");
            sekretari = isecretaryRepository.getAll();
            return sekretari;
        }
       
        
        public Boolean IsUsernameValid(String username)
        {
            iuserRepository = new UserRepository("../../Fajlovi/users.xml");
            if (iuserRepository.getUserByUsername(username) == null)
            {
                return true;
            }
            return false;
        }

        public Boolean IsPasswordValid(String password)
        {
            if (password.Length < MinLengthPass)
            {
                return false;
            }
            return true;
        }

        public Boolean IsJMBGValid(String jmbg)
        {
            iuserRepository = new UserRepository("../../Fajlovi/users.xml");
            if (iuserRepository.getUserByJmbg(jmbg) == null)
            {
                return true;
            }
            return false;
        }


        public Secretary GetSecretary(String username)
      {
         // TODO: implement
         return null;
      }
      
      public void EditSecretary(Secretary secretary)
      {
         // TODO: implement
      }
   
      public ISecretaryRepository isecretaryRepository;
      public IUserRepository iuserRepository;
   
   }
}