/***********************************************************************
 * Module:  Smjena.cs
 * Purpose: Definition of the Class Ljekar.Smjena
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.Employee
{
   public class WorkingTime : Entity
    {
      public Model.Employee.Doctor doctor { get; set; }
      public Model.Room.Hall hall;
   
      public DateTime startDay { get; set; }
        public DateTime endDay { get; set; }
        public String startTime { get; set; }
        public String endTime { get; set; }

    }
}