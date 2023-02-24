
using Model.Employee;
using Model.User;
using SimsProject.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimsProject.View;
using SimsProject.Repository.UserRepository;
using Repository.UserRepository;

namespace SimsProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XmlReaderWriter rw = new XmlReaderWriter();

        public IUserRepository iuserRepository;


        public static List<Manager> menadzeri
        {
            get;
            set;

        }
        public static List<User> korisnici
        {
            get;
            set;

        }

        public static List<Patient> pacijenti
        {
            get;
            set;

        }

        public static List<Secretary> sekretari
        {
            get;
            set;

        }
        public static List<Doctor> doktori
        {
            get;
            set;

        }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            IUserRepository repo = new UserRepository("../../Fajlovi/users.xml");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new RegistracijaPacijenta();
            s.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            Manager manager = new Manager
            {
                id = 1,
                salary = 10000.0,
                numberOfDaysUsed = 10,
                password = "glavna123",
                name = "Kristina",
                surname = "Mucibabic",
                jmbg = "12345584",
                dateOfBirth = DateTime.Now,
                phoneNumber = "423432",
                guestAccount = false,
                email = "glavna@d.com",
                userName = "glavna"

            };
            User user = new User
            {
                password = "glavna123",
                name = "Kristina",
                surname = "Mucibabic",
                jmbg = "12345584",
                dateOfBirth = DateTime.Now,
                phoneNumber = "423432",
                guestAccount = false,
                email = "glavna@d.com",
                userName = "glavna"
            };
            
            


            userController = new Controller.UserController.UserController();
            userController.RegisterUser(user);

            menadzeri = new List<Manager>();
            menadzeri.Add(manager);
            rw.SerializeObject<List<Manager>>(menadzeri, "../../Fajlovi/managers.xml");
        }
        public Controller.UserController.UserController userController;
        public Controller.UserController.PatientController patientController;
        public Controller.UserController.SecretaryController secretaryController;
        public Controller.UserController.DoctorController doctorController;

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bool pronadjen = false;
            bool postoji = false;

            korisnici = new List<User>();
            userController = new Controller.UserController.UserController();
            korisnici = userController.GetAllUsers();

            pacijenti = new List<Patient>();
            patientController = new Controller.UserController.PatientController();
            pacijenti = patientController.GetAllPatient();

            sekretari = new List<Secretary>();
            secretaryController = new Controller.UserController.SecretaryController();
            sekretari = secretaryController.GetAllSecretary();

            doktori = new List<Doctor>();
            doctorController = new Controller.UserController.DoctorController();
            doktori = doctorController.GetAllDoctors();


            User user = new User
            {
                userName = xUserName.Text,
                password = xPassword.Text
            };

            pronadjen = userController.Login(user);
             
            if (pronadjen)
            {
                 foreach (var pacijent in pacijenti)
                 {
                     if (pacijent.userName.Equals(xUserName.Text))
                     {
                       
                        var w = new PocetnaPacijent();
                         w.Show();
                        //this.Close();
                    }
                 }
                  if (("glavna").Equals(xUserName.Text))
                  {
                      var w = new PocetnaUpravnika();
                      w.Show();
                    //this.Close();
                  }

                foreach (var sekretar in sekretari)
                {
                    if (sekretar.userName.Equals(xUserName.Text))
                    {
                        var w = new PocetnaSekretar();
                        w.Show();
                        //this.Close();
                    }
                }
                foreach (var doktor in doktori)
                {
                    if (doktor.userName.Equals(xUserName.Text))
                    {
                        var w = new PocetnaLjekara();
                        w.Show();
                        //this.Close();
                    }
                }


            }
            if (!pronadjen)
            {
                MessageBox.Show("Korisnicko ime ili lozinka neispravni! Molim Vas unesite ispravno korisnicko ime i lozinku", "Neispravno ime");
                return;
            }

            this.Close();
        }
    }
}
