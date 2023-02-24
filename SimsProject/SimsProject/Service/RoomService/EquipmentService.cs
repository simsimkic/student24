/***********************************************************************
 * Module:  EquipmentService.cs
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using SimsProject.Repository.RoomRepository;
using System;

namespace Service.RoomService
{
   public class EquipmentService
   {
      public Model.Room.SuppliesOfEquipment AddEquipment(Model.Room.SuppliesOfEquipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteEquipment(Model.Room.SuppliesOfEquipment equipment)
      {
         // TODO: implement
      }
      
      public Model.Room.SuppliesOfEquipment EditEquipment(Model.Room.SuppliesOfEquipment equipment)
      {
         // TODO: implement
         return null;
      }
   
      public IEquipmentRepository iequipmentRepository;
      public IWarehouseRepository iwarehouseRepository;
   
   }
}