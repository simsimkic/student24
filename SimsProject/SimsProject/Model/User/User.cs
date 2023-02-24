/***********************************************************************
 * Module:  Osoba.cs
 * Purpose: Definition of the Class Pacijent.Osoba
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;
using System.Runtime.CompilerServices;

namespace Model.User
{
   public class User : Entity
   {
        
        public String userName { get; set; }
        public String password { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String jmbg { get; set; }
        public DateTime dateOfBirth { get; set; }
        public String phoneNumber { get; set; }
        public String gender { get; set; }
        public Boolean guestAccount = false;
        public String email { get; set; }
        public String address { get; set; }

       /* public User(String username, String password, String name, String surname , String jmbg, DateTime dateOfBirth,
           String phoneNumber, String gender, Boolean guestAccount, String email, String address ,int id):base(id)
        {
            this.userName = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.jmbg = jmbg;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.guestAccount = guestAccount;
            this.email = email;
            this.address = address;
        }
        public User(int id) : base(id)
        {
           
        }*/
    }

}