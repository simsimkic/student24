/***********************************************************************
 * Module:  RenvationRepository.cs
 * Purpose: Definition of the Class Service.RoomService.RenvationRepository
 ***********************************************************************/

using Model.Room;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.RoomRepository;
using SimsProject;
using System;
using System.Collections.Generic;

namespace Repository.RoomRepository
{
   public class RenvationRepository : GenericRepository<Renovation>, IRenvationRepository
    {

        public RenvationRepository(String filePath) : base(filePath) { }
        public Renovation GetByRoom(Room room)
      {
         // TODO: implement
         return null;
      }
     
      private String path;
   
   }
}