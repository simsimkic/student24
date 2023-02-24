/***********************************************************************
 * Module:  UserService.cs
 * Purpose: Definition of the Class Service.UserService.UserService
 ***********************************************************************/

using Model.User;
using Service.UserService;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
   public class UserController
   {

        
       
        public Boolean IsUsernameValid(String username)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean IsPasswordValid(String password)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean IsJMBGValid(String jbmg)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean Login(User user)
      {
            return userService.Login(user);
      }
      
      public User EditAccount(User user)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteAccount(User user)
      {
         // TODO: implement
      }
        public List<User> GetAllUsers()
        {
            List<User> korisnici = new List<User>();
            userService = new UserService();
            korisnici=userService.GetAllUsers();

            return korisnici;
        }

        public User RegisterUser(User user)
        {

            userService = new UserService();
            return userService.RegisterUser(user);
            
        }

        public UserService userService;
        private int MinLengthPass = 5;
   
   }
}