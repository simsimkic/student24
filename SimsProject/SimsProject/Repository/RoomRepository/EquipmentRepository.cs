/***********************************************************************
 * Module:  EquipmentRepository.cs
 * Purpose: Definition of the Class Service.RoomService.EquipmentRepository
 ***********************************************************************/

using Model.Room;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.RoomRepository;
using System;
using System.Collections.Generic;

namespace Repository.RoomRepository
{
   public class EquipmentRepository : GenericRepository<SuppliesOfEquipment>, IEquipmentRepository
    {

      public EquipmentRepository(String filePath) : base(filePath) { }
       
      
      
      public SuppliesOfEquipment GetEquipment(int id)
      {
         // TODO: implement
         return null;
      }
     
   
      private String path;
   
   }
}