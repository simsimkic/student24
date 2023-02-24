/***********************************************************************
 * Module:  RenovationServicce.cs
 * Purpose: Definition of the Class Service.RenovationServicce
 ***********************************************************************/

using Model.Room;
using System;

namespace Controller.RoomController
{
   public class RenovationController
   {
      public Renovation ScheduleRenovation(Renovation renovation)
      {
         // TODO: implement
         return null;
      }
      
      public Renovation EditRenovation(Renovation renovation)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelRenovation(Renovation renovation)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean IsRoomAvailable(Model.Room.Room room)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean IsTermValid(Model.Examination.Term term)
      {
         // TODO: implement
         return false;
      }
   
      public Service.RoomService.RenovationService renovationService;
   
   }
}