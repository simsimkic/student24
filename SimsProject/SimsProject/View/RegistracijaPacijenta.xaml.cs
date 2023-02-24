using Controller.MedicalRecordController;
using Model.User;
using Repository.UserRepository;
using SimsProject.helpers;
using SimsProject.Repository.UserRepository;
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
using System.Windows.Shapes;

namespace SimsProject.View
{
    /// <summary>
    /// Interaction logic for RegistracijaPacijenta.xaml
    /// </summary>
    public partial class RegistracijaPacijenta : Window
    {
        
        public Controller.UserController.PatientController patientController;

        XmlReaderWriter rw = new XmlReaderWriter();
        public Controller.UserController.UserController userController;
        public Controller.MedicalRecordController.MedicalRecordController medicalRecordController;

        public static List<Patient> pacijenti
        {
            get;
            set;

        }
        public static List<User> korisnici
        {
            get;
            set;

        }
        public RegistracijaPacijenta()
        {
            InitializeComponent();
            this.DataContext = this;
            IUserRepository repo = new UserRepository("../../Fajlovi/users.xml");

            korisnici = new List<User>();
            userController = new Controller.UserController.UserController();
            korisnici = userController.GetAllUsers();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dateBirth.SelectedDate == null)
            {
                MessageBox.Show("Datum ne smije biti prazan", "Neispravan datum");
                return;
            }
            
            if ((DateTime)dateBirth.SelectedDate > DateTime.Now)
            {
                MessageBox.Show("Morate odabradi datum iz proslosti!", "Neispravan datum");
                return;
            }

            Patient inf = new Patient
            {
                userName = korIme.Text,
                name = xIme.Text,
                surname = prezime.Text,
                password = lozinka.Text,
                jmbg = xJbmg.Text,
                dateOfBirth = dateBirth.SelectedDate.Value,
                email=xEmail.Text,
                address=xAdresa.Text,
                phoneNumber=xPhone.Text,
                gender=xPol.Text

            };

            User user = new User
            {
                userName = korIme.Text,
                name = xIme.Text,
                surname = prezime.Text,
                password = lozinka.Text,
                jmbg = xJbmg.Text,
                dateOfBirth = dateBirth.SelectedDate.Value,
                email = xEmail.Text,
                address = xAdresa.Text,
                phoneNumber = xPhone.Text,
                gender = xPol.Text

            };

          
            patientController = new Controller.UserController.PatientController();
            if (patientController.RegisterPatient(inf) == null)
            {

                MessageBox.Show("Podaci su neispravni", "Neispravno");
                return;
            }
            medicalRecordController = new Controller.MedicalRecordController.MedicalRecordController();
            medicalRecordController.CreateRecord(inf);

            userController = new Controller.UserController.UserController();
            userController.RegisterUser(user);

            var s = new MainWindow();
            s.Show();

            this.Close();

        }

        private void xAdresa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void xPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
