/***********************************************************************
 * Module:  Employee.cs
 * Purpose: Definition of the Class Model.User.Employee
 ***********************************************************************/

using Model.Employee;
using System;

namespace Model.User
{
   public class Employee : User
    {
       

        public System.Collections.ArrayList notification;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetNotification()
      {
         if (notification == null)
            notification = new System.Collections.ArrayList();
         return notification;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetNotification(System.Collections.ArrayList newNotification)
      {
         RemoveAllNotification();
         foreach (Notification oNotification in newNotification)
            AddNotification(oNotification);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddNotification(Notification newNotification)
      {
         if (newNotification == null)
            return;
         if (this.notification == null)
            this.notification = new System.Collections.ArrayList();
         if (!this.notification.Contains(newNotification))
            this.notification.Add(newNotification);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveNotification(Notification oldNotification)
      {
         if (oldNotification == null)
            return;
         if (this.notification != null)
            if (this.notification.Contains(oldNotification))
               this.notification.Remove(oldNotification);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllNotification()
      {
         if (notification != null)
            notification.Clear();
      }
      public Vacation vacation;
   
      public int id { get; set; }
      public double salary { get; set; }
      public int numberOfDaysUsed { get; set; }

    }
}