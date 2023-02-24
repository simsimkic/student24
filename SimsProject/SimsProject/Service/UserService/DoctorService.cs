/***********************************************************************
 * Module:  DoctorService.cs
 * Purpose: Definition of the Class Service.ExaminationService.DoctorService
 ***********************************************************************/

using Model.Employee;
using System;
using System.Collections.Generic;
using SimsProject.Repository.UserRepository;
using Repository.UserRepository;

namespace Service.UserService
{
   
    public class DoctorService
   {
        private int MinLengthPass = 5;
        public Doctor RegisterDoctor(Doctor doctor)
        {

            if (IsJMBGValid(doctor.jmbg) && IsUsernameValid(doctor.userName) && IsPasswordValid(doctor.password))
            {
                idoctorRepository = new DoctorRepository("../../Fajlovi/doktori.xml");
                return idoctorRepository.save(doctor);
            }

            return null;
            
        }
      
      public List <Doctor> GetDoctorBySpecility(Specialty speciality)
      {
         // TODO: implement
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

        public List<Doctor> GetAllDoctors()
      {
            List<Doctor> doktori = new List<Doctor>();
            idoctorRepository = new DoctorRepository("../../Fajlovi/doktori.xml");
            doktori = idoctorRepository.getAll();
            return doktori;
        }
      
      public Doctor GetDoctor(String username)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetDoctorByDate(DateTime startDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
      
      public void EditDoctor(Model.Employee.Doctor doctor)
      {
         // TODO: implement
      }
   
      
      public IDoctorRepository idoctorRepository;
      public IUserRepository iuserRepository;
   
   }
}