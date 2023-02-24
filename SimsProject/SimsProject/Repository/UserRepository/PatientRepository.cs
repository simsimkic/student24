/***********************************************************************
 * Module:  PatientRepository.cs
 * Purpose: Definition of the Class Service.UserService.PatientRepository
 ***********************************************************************/

using Model.User;
using SimsProject.helpers;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class PatientRepository : GenericRepository<Patient>, IPatientRepository
   {
        public PatientRepository(String filePath) : base(filePath){}
      
        public Patient getPatientByJmbg(String jmbg)
        {
            List<Patient> patients = getAll();
            foreach (Patient patient in patients)
            {
                if (patient.jmbg.Equals(jmbg))
                {
                    return patient;
                }
            }

            return null;
        }

        public Patient getPatient(String username)
        {
         // TODO: implement
         return null;
        }
        
        private string path;
   
   }
}