/***********************************************************************
 * Module:  HallRepository.cs
 * Purpose: Definition of the Class Repository.RoomRepository.HallRepository
 ***********************************************************************/

using Model.Room;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.RoomRepository;
using System;
using System.Collections.Generic;

namespace Repository.RoomRepository
{
   public class HallRepository : GenericRepository<Hall>, IHallRepository
    {

       public HallRepository(String filePath) : base(filePath) { }

       public List<Hall> GetAllHall()
       {
         // TODO: implement
         return null;
       }
      
       private String path;
   
   }
}