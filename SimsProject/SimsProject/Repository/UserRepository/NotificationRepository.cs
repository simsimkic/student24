/***********************************************************************
 * Module:  NotificationRepository.cs
 * Purpose: Definition of the Class Service.UserService.NotificationRepository
 ***********************************************************************/

using Model.User;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class NotificationRepository : GenericRepository<Notification>, INotificationRepository
    {

      public NotificationRepository(String filePath) : base(filePath) { }
       
      public Boolean GetNotification(int notifyId)
      {
         // TODO: implement
         return false;
      }

      private String path;
   
   }
}