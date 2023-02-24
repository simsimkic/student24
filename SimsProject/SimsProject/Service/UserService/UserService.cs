/***********************************************************************
 * Module:  UserService.cs
 * Purpose: Definition of the Class Service.UserService.UserService
 ***********************************************************************/

using Model.User;
using SimsProject.helpers;
using System;
using System.Collections.Generic;
using System.Windows;
using Repository.UserRepository;
using SimsProject.Repository.UserRepository;

namespace Service.UserService
{
   public class UserService
   {

        public List<User> GetAllUsers()
        {
            List<User>  usersList = new List<User>();
            iuserRepository = new UserRepository("../../Fajlovi/users.xml");
            usersList =iuserRepository.getAll();

            return usersList;
        }


        public Boolean Login(User user)
        {
            if (isUserExist(user))
            {
               
                return iuserRepository.saveCurrentUser(user); 
            }
            return false;
        }

       public Boolean isUserExist(User user)
       {
            List<User> userList = new List<User>();
            userList = GetAllUsers();

            return isUsernameExist(user,userList);
            
       }

        public Boolean isUsernameExist(User user, List<User> userList)
        {
            foreach (var oneUser in userList)
            {
                if (oneUser.userName.Equals(user.userName))
                {
                    return isUserPasswordValid(user.password, oneUser);
                }
            }

            return false;
        }
        public Boolean isUserPasswordValid(String password,User user)
        {
            if (!user.password.Equals(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
      public Boolean EditAccount(User user)
      {
         // TODO: implement
         return false;
      }
      
      public void DeleteAccount(User user)
      {
         // TODO: implement
      }

       public Model.User.User RegisterUser(User user)
        {
            // TODO: implementnew 
            iuserRepository = new UserRepository("../../Fajlovi/users.xml");
            return iuserRepository.save(user);
        }

       public IUserRepository iuserRepository;
   
       private int MinLengthPass = 5;
   
   }
}