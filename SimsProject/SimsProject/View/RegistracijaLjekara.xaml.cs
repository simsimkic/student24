using Model.Employee;
using System;
using Model.User;
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
using SimsProject.Repository.UserRepository;
using Repository.UserRepository;
using System.Xml;
using SimsProject.helpers;

namespace SimsProject.View
{
    /// <summary>
    /// Interaction logic for RegistracijaLjekara.xaml
    /// </summary>
    public partial class RegistracijaLjekara : Window
    {
        XmlReaderWriter rw = new XmlReaderWriter();
        public IUserRepository iuserRepository;

        public Controller.UserController.DoctorController doctorController;
        public Controller.UserController.UserController userController;

        public RegistracijaLjekara()
        {
            InitializeComponent();
            this.DataContext = this;

            IUserRepository repo = new UserRepository("../../Fajlovi/users.xml");

        }

        private void xRegistruj_Click(object sender, RoutedEventArgs e)
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

            Specialty sp = new Specialty
            {
                name = specijalnost.Text

            };

            Doctor inf = new Doctor
            {
                userName = xUserName.Text,
                name = xName.Text,
                password = xPassword.Text,
                jmbg = xJmbg.Text,
                dateOfBirth = dateBirth.SelectedDate.Value,
                email = xEmail.Text,
                address = xAdresa.Text,
                phoneNumber = xPhone.Text,
                gender = xPol.Text,
                surname = surname.Text,
                specialty = sp,
                salary = 40000
            };

            User user = new User
            {
                userName = xUserName.Text,
                name = xName.Text,
                password = xPassword.Text,
                jmbg = xJmbg.Text,
                dateOfBirth = dateBirth.SelectedDate.Value,
                email = xEmail.Text,
                address = xAdresa.Text,
                phoneNumber = xPhone.Text,
                gender = xPol.Text,
                surname = surname.Text
               
            };
           doctorController = new Controller.UserController.DoctorController();

            if (doctorController.RegisterDoctor(inf) == null)
            {

                MessageBox.Show("Neispravni podaci", "Neispravno");
                return;
            }
            userController = new Controller.UserController.UserController();
            userController.RegisterUser(user);

            var s = new PocetnaUpravnika();
            s.Show();
            this.Close();
        }
    }
}
