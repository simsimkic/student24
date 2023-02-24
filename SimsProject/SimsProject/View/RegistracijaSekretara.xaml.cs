using Model.Employee;
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
    /// Interaction logic for RegistracijaSekretara.xaml
    /// </summary>
    public partial class RegistracijaSekretara : Window
    {
        public Controller.UserController.SecretaryController secretaryController;
        public Controller.UserController.UserController userController;
        XmlReaderWriter rw = new XmlReaderWriter();
        public RegistracijaSekretara()
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

            Secretary inf = new Secretary
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
                surname = surname.Text,
               
            };

           
            secretaryController = new Controller.UserController.SecretaryController();

             if (secretaryController.RegisterSecretary(inf) == null)
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
