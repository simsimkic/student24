/***********************************************************************
 * Module:  GuestUserRepository.cs
 * Purpose: Definition of the Class Service.UserService.GuestUserRepository
 ***********************************************************************/

using Model.User;
using SimsProject.helpers;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.UserRepository;
using System;
using System.Collections.Generic;

namespace Repository.UserRepository
{
   public class GuestUserRepository { 

      XmlReaderWriter rw = new XmlReaderWriter();
      public Patient GetGuestPatient(String jmbg)
      {
          // TODO: implement
          return null;
      }
        public List<Patient> getAllGuestPatient()
        {
            List<Patient> entityList = rw.DeSerializeObject<List<Patient>>(path);

            return entityList;
        }
        public void DeleteGuestPatient(String jmbg)
      {
            List<Patient> guestPatients = getAllGuestPatient();
            foreach (Patient patient in guestPatients)
            {
                if (patient.jmbg.Equals(jmbg))
                   guestPatients.Remove(patient);
            }
            //rw.SerializeObject<List<Patient>>(guestPatients, path);

        }
        public Patient NewGuestUser(Patient patient)
        {
            List<Patient> entityList = getAllGuestPatient();
            //List<Patient> entityList = new List<Patient>();
            entityList.Add(patient);
            rw.SerializeObject<List<Patient>>(entityList, path);
            return patient;
        }

        private string path="../../Fajlovi/guestPacijenti.xml";

    }
}