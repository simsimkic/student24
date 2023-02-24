/***********************************************************************
 * Module:  NotificationService.cs
 * Purpose: Definition of the Class Service.UserService.NotificationService
 ***********************************************************************/

using Model.User;
using Service.NotificationService;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Service.UserService
{
   public class NotificationService
   {
      public Boolean GetNotification(int notifyId)
      {
         // TODO: implement
         return false;
      }
      
      public List<Notification> GetAllNotification(String username)
      {
         // TODO: implement
         return null;
      }
      
      public Notification ReadNotification(Notification notification)
      {
         // TODO: implement
         return null;
      }
      
      public Notification AddNotification(Notification notification)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteNotification(Notification notification)
      {
         // TODO: implement
      }
      
      public void SendNotification(INotificationStrategy strategy)
      {
         // TODO: implement
      }
   
      public IPatientRepository ipatientRepository;
      public IManagerRepository imanagerRepository;
      public ISecretaryRepository isecretaryRepository;
      public IDoctorRepository idoctorRepository;
      public INotificationRepository inotificationRepository;

      public INotificationStrategy iNotificationStrategy;
   
   }
}