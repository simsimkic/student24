using System;
using Model.User;
using System.Collections.Generic;

using Repository.UserRepository;
using SimsProject.Repository.UserRepository;

namespace Service.UserService
{
    public class GuestUserService
    {
        public Patient registerGuestPatient(Patient guestPatient)
        {
            if ( isJmbgValid(guestPatient.jmbg) )
            {
                guestPatient.guestAccount = true;
                guestUserRepository = new GuestUserRepository();
                return guestUserRepository.NewGuestUser(guestPatient);
            }

            return null;
        }

        private Boolean isJmbgValid(String jmbg)
        {
            ipatientRepository = new PatientRepository("../../Fajlovi/pacijenti.xml");

            if (ipatientRepository.getPatientByJmbg(jmbg) == null)
            {
                return true;
            }
                
            return false;
        }

        
        public List<Patient> getAllGuestPatients()
        {
            List<Patient> guestPacijenti = new List<Patient>();
            guestUserRepository = new GuestUserRepository();
            guestPacijenti = guestUserRepository.getAllGuestPatient();
            
            return guestPacijenti;
        }

        public GuestUserRepository guestUserRepository;

        public IPatientRepository ipatientRepository;

    }
}
