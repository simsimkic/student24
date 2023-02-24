/***********************************************************************
 * Module:  DoctorService.cs
 * Purpose: Definition of the Class Service.ExaminationService.DoctorService
 ***********************************************************************/

using Model.Employee;
using Service.UserService;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
   public class DoctorController
   {
      public List <Doctor> GetDoctorBySpecility(Specialty speciality)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAllDoctors()
      {
            List<Doctor> doktori = new List<Doctor>();
            doctorService = new DoctorService();
            doktori = doctorService.GetAllDoctors();

            return doktori;
        }
      
      public Doctor GetDoctor(String username)
      {
         // TODO: implement
         return null;
      }
        public Model.Employee.Doctor RegisterDoctor(Doctor doctor)
        {
            doctorService = new DoctorService();
            return doctorService.RegisterDoctor(doctor);

        }
        public DoctorService doctorService;
   
   }
}