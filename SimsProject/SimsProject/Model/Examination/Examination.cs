/***********************************************************************
 * Module:  Pregled.cs
 * Purpose: Definition of the Class Pregled.Pregled
 ***********************************************************************/

using Model.User;
using SimsProject.Model.Entity;
using System;

namespace Model.Examination
{
    public class Examination : Entity
    {
        public RefferalToSpecialist refferalToSpecialist;
        public Therapy therapy;
        public Model.Room.Hall hall;
        public Model.Employee.Doctor doctor { get; set; }
        public Patient patient { get; set; }
        public Recipe recipe { get; set; }
        public Term term { get; set; }

        public Boolean completed { get; set; }

        private int id=0;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
   
   }
