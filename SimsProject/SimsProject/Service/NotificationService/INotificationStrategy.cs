/***********************************************************************
 * Module:  INotificationStrategy.cs
 * Purpose: Definition of the Interface Service.NotificationService.INotificationStrategy
 ***********************************************************************/

using Model.User;
using System;

namespace Service.NotificationService
{
   public interface INotificationStrategy
   {
      Notification SendNotification(int notifyId, String username);
   }
}