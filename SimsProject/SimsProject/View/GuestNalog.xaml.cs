using Model.User;
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
    /// Interaction logic for GuestNalog.xaml
    /// </summary>
    public partial class GuestNalog : Window
    {

        public Controller.UserController.GuestUserController guestUserController;

        XmlReaderWriter rw = new XmlReaderWriter();
        public Controller.UserController.UserController userController;

        public static List<Patient> guestPacijenti
        {
            get;
            set;
        }
        public static List<User> korisnici
        {
            get;
            set;
        }

        public GuestNalog()
        {
            InitializeComponent();
            this.DataContext = this;

            korisnici = new List<User>();
            userController = new Controller.UserController.UserController();
            korisnici = userController.GetAllUsers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Patient inf = new Patient
            {
                name = ime.Text,
                surname = prezime.Text,
                jmbg = jmbg.Text
            };

            guestUserController = new Controller.UserController.GuestUserController();
            if (guestUserController.RegisterGuestPatient(inf) == null)
            {
                MessageBox.Show("Error!!", "Neispravno korisničko ime ili lozinka.");
                return;
            }
           
            var s = new MainWindow();
            s.Show();

            this.Close();

        }
    }
}
