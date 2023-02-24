/***********************************************************************
 * Module:  Oprema.cs
 * Purpose: Definition of the Class Pacijent.Oprema
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.Room
{
   public class SuppliesOfEquipment:Entity
   {
      public Equipment equipment;
      public Room room;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Room GetRoom()
      {
         return room;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newRoom</param>
      public void SetRoom(Room newRoom)
      {
         if (this.room != newRoom)
         {
            if (this.room != null)
            {
               Room oldRoom = this.room;
               this.room = null;
               oldRoom.RemoveSuppliesOfEquipment(this);
            }
            if (newRoom != null)
            {
               this.room = newRoom;
               this.room.AddSuppliesOfEquipment(this);
            }
         }
      }
   
      private int quantity;
   
   }
}