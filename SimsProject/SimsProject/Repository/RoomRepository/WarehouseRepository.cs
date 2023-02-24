/***********************************************************************
 * Module:  WarehouseRepository.cs
 * Purpose: Definition of the Class Repository.RoomRepository.WarehouseRepository
 ***********************************************************************/

using Model.Room;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.RoomRepository;
using System;

namespace Repository.RoomRepository
{
   public class WarehouseRepository : GenericRepository<Warehouse>, IWarehouseRepository
    {

      public WarehouseRepository(String filePath) : base(filePath) { }
      
      public Warehouse GetWareHouse(Warehouse warehouse)
      {
         // TODO: implement
         return null;
      }
   
      private String path;
   
   }
}