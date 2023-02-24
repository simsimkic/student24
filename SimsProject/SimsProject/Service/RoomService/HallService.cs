/***********************************************************************
 * Module:  RoomService.cs
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using Model.Room;
using SimsProject.Repository.RoomRepository;
using System;

namespace Service.RoomService
{
   public class HallService
   {
      public Hall CreateHall(Hall hall)
      {
         // TODO: implement
         return null;
      }
      
      public Hall EditHall(Hall hall)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteHall(Hall hall)
      {
         // TODO: implement
      }
   
      public EquipmentService equipmentService;
      public IHallRepository ihallRepository;
   
   }
}