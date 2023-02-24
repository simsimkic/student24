using Model.Employee;
using Model.Examination;
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
using System.Windows.Shapes;

namespace SimsProject.View
{
    /// <summary>
    /// Interaction logic for Zakazivanje.xaml
    /// </summary>
    public partial class Zakazivanje : Window
    {
        public Controller.UserController.DoctorController doctorController;
        XmlReaderWriter rw = new XmlReaderWriter();
        public List<Doctor> doce
        {
            get;
            set;
        }

        Patient trPacijent;

        public String dateString { get; set; }
        public String dateString1 { get; set; }
        public DateTime datum1 { get; set; }
        public DateTime datum2 { get; set; }
        public Zakazivanje()
        {
            InitializeComponent();
            this.DataContext = this;

            doctorController = new Controller.UserController.DoctorController();
            List<Doctor> doktori = new List<Doctor>();
            doktori = doctorController.GetAllDoctors();

            User prKor = new User();
            User temp = rw.DeSerializeObject<User>("../../Fajlovi/korisnik.xml");
            prKor = temp;

            trPacijent = new Patient();
            List<Patient> pacijenti = rw.DeSerializeObject<List<Patient>>("../../Fajlovi/pacijenti.xml");
            foreach(var p in pacijenti)
            {
                if (prKor.userName.Equals(p.userName))
                {
                    trPacijent = p;
                }
            }

            xLjekari.ItemsSource = doktori;
            xLjekariData.ItemsSource = doktori;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new Termini((Doctor)xLjekariData.SelectedItem, (DateTime)xDatum.SelectedDate,trPacijent);
            s.Show();

           
        }
        
        private static DateTime ConvertToDateTime(string value)
        {
            DateTime convertedDate = DateTime.Now;
            try
            {
                convertedDate = Convert.ToDateTime(value);
                Console.WriteLine("'{0}' converts to {1} {2} time.",
                                  value, convertedDate,
                                  convertedDate.Kind.ToString());
                return convertedDate;
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the proper format.", value);
                return convertedDate;

            }

        }
    }
}
