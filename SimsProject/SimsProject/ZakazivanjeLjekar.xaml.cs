using Model.Employee;
using Model.User;
using SimsProject.helpers;
using SimsProject.View;
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

namespace SimsProject
{
    /// <summary>
    /// Interaction logic for ZakazivanjeLjekar.xaml
    /// </summary>
    public partial class ZakazivanjeLjekar : Window
    {
        public Controller.UserController.PatientController patientController;
        XmlReaderWriter rw = new XmlReaderWriter();

        Doctor trDoctor;

        public List<Patient> patients
        {
            get;
            set;
        }

        public ZakazivanjeLjekar()
        {
            InitializeComponent();
            this.DataContext = this;

            User prKor = new User();
            User temp = rw.DeSerializeObject<User>("../../Fajlovi/korisnik.xml");
            prKor = temp;

            trDoctor = new Doctor();
            List<Doctor> doctors = rw.DeSerializeObject<List<Doctor>>("../../Fajlovi/doktori.xml");
            foreach (var p in doctors)
            {
                if (prKor.userName.Equals(p.userName))
                {
                    trDoctor = p;
                }
            }

            patientController = new Controller.UserController.PatientController();
            List<Patient> patients = new List<Patient>();
            patients = patientController.GetAllPatient();

            xLjekariData.ItemsSource = patients;


        

    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new Termini1(trDoctor,(DateTime)xDatum.SelectedDate,(Patient)xLjekariData.SelectedItem);
            s.Show();
            
        }
    }
}
