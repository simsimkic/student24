/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.EmployeeService.PatientService
 ***********************************************************************/

using Model.User;
using SimsProject.helpers;
using System;
using System.Collections.Generic;
using Repository.UserRepository;
using SimsProject.Repository.UserRepository;

namespace Service.UserService
{
   public class PatientService
   {

        private int MinLengthPass = 5;
        public Patient GetPatient(String username)
      {
         // TODO: implement
         return null;
      }
      
      public Patient RegisterPatient(Patient patient)
      {
            if ((IsJMBGValid(patient.jmbg) && IsUsernameValid(patient.userName) && IsPasswordValid(patient.password)))
            {
                ipatientRepository = new PatientRepository("../../Fajlovi/pacijenti.xml");
                return ipatientRepository.save(patient);
            }

            return null;
         
      }
        
        public Boolean IsUsernameValid(String username)
        {
            iuserRepository = new UserRepository("../../Fajlovi/users.xml");
            if (iuserRepository.getUserByUsername(username) == null)
            {
                return true;
            }
            return false;
        }

        public Boolean IsPasswordValid(String password)
        {
            if (password.Length < MinLengthPass)
            {
                return false;
            }
            return true;
        }

        public Boolean IsJMBGValid(String jmbg)
        {
            iuserRepository = new UserRepository("../../Fajlovi/users.xml");
            if (iuserRepository.getUserByJmbg(jmbg) == null)
            {
                return true;
            }
            return false;
        }

        private Boolean checkGuestPatient(String jmbg)
        {
            guestUserRepository = new GuestUserRepository();

            foreach (Patient patient in guestUserRepository.getAllGuestPatient())
            {
                if (patient.jmbg.Equals(jmbg))
                {
                    guestUserRepository.DeleteGuestPatient(jmbg);
                    return true;
                }
            }
            return false;
        }
        public List<Patient> GetAllPatients()
        {
            List<Patient> pacijenti = new List<Patient>();
            ipatientRepository = new PatientRepository("../../Fajlovi/pacijenti.xml");
            pacijenti = ipatientRepository.getAll();
            return pacijenti;
        }
       

      
      public IPatientRepository ipatientRepository;

      public GuestUserRepository guestUserRepository;

      public IUserRepository iuserRepository;

      public Service.MedicalRecordService.MedicalRecordService medicalRecordService;
      
   
   }
}