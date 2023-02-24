/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.EmployeeService.PatientService
 ***********************************************************************/

using Model.User;
using SimsProject.helpers;
using System;
using System.Collections.Generic;

namespace Controller.UserController
{
   public class PatientController
   {
        XmlReaderWriter rw = new XmlReaderWriter();

        public static List<Patient> pacijenti
        {
            get;
            set;

        }
        public List<Patient> GetAllPatient()
      {
            pacijenti = new List<Patient>();
            patientService = new Service.UserService.PatientService();
            pacijenti = patientService.GetAllPatients();

            return pacijenti;
        }
      
      public Patient GetPatient(String username)
      {
            return null;
        }
        public Patient RegisterPatient(Patient patient)
        {
            
            patientService = new Service.UserService.PatientService();
            return patientService.RegisterPatient(patient);


        }

        public Service.UserService.PatientService patientService;
   
   }
}