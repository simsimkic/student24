/***********************************************************************
 * Module:  HospitalStay.cs
 * Purpose: Definition of the Class Model.MedicalRecord.HospitalStay
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.MedicalRecord
{
   public class HospitalStay:Entity
   {
      public int Id()
      {
         // TODO: implement
         return 0;
      }
   
      public Model.User.Patient patient;
      public Model.Employee.Doctor doctor;
      public Model.Examination.Term term;
      public Model.Room.Bedroom bedroom;
   
   }
}