/***********************************************************************
 * Module:  BedroomService.cs
 * Purpose: Definition of the Class Service.RoomService.BedroomService
 ***********************************************************************/

using Model.Room;
using SimsProject.Repository.RoomRepository;
using System;

namespace Service.RoomService
{
   public class BedroomService
   {
      public Bedroom CreateBedroom(Bedroom bedroom)
      {
         // TODO: implement
         return null;
      }
      
      public Bedroom EditBedroom(Bedroom bedroom)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteBedroom(Bedroom bedroom)
      {
         // TODO: implement
      }
   
      public EquipmentService equipmentService;
      public IBedroomRepository ibedroomRepository;
   
   }
}