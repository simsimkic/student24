using Model.Employee;
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
using System.Timers;
using System.Windows.Forms;
using Service.TermService;
using Model.Examination;

namespace SimsProject.View
{
    /// <summary>
    /// Interaction logic for RadnoVrijeme.xaml
    /// </summary>
    public partial class RadnoVrijeme : Window
    {

        XmlReaderWriter rw = new XmlReaderWriter();

        public String dateString { get; set; }
        public String dateString1 { get; set; }
        public DateTime datum1 { get; set; }
        public DateTime datum2 { get; set; }

        public RadnoVrijeme()
        {

            InitializeComponent();
            this.DataContext = this;

            List<Doctor> doctor = rw.DeSerializeObject<List<Doctor>>("../../Fajlovi/doktori.xml");

            dataGrid1.ItemsSource = doctor;



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



        private void xPotvrda_Click(object sender, RoutedEventArgs e)
        {
            //String vr = xPocetak.Text;
            String d = datum.SelectedDate.ToString();
            String dK = datumKraj.SelectedDate.ToString();

            //dateString = "06 July 2008 7:32:47 AM";
            datum1 = ConvertToDateTime(dK);
            datum2 = ConvertToDateTime(d);

            WorkingTime wt = new WorkingTime
            {
                startDay = datum2,
                endDay = datum1,
                startTime = xPocetak.Text,
                endTime = xKraj.Text,
                doctor = (Doctor)dataGrid1.SelectedItem
            };

            workingTimeController = new Controller.UserController.WorkingTimeController();
            workingTimeController.AddWorkingTime(wt);

           

            //
            Doctor doco = new Doctor();
            doco = (Doctor)dataGrid1.SelectedItem;

            var datumList = new List<DateTime>();

            String pocetak = xPocetak.Text;
            String kraj = xKraj.Text;





            for (var j = datum2; j <= datum1; j = j.AddDays(1))
            {
                datumList.Add(j);
            }


            foreach (var i in datumList)
            {
                int poce = int.Parse(pocetak);
                int kr = int.Parse(kraj);

                while (poce < kr)
                {
                    int p = poce;
                    int k = ++poce;

                    String joj = p.ToString();
                    String joj1 = k.ToString();

                    Period sr = new Period
                    {
                        usernameDoctor = doco.userName,
                        day = i,
                        startTime = joj,
                        endTime = joj1

                    };

                    termController = new Controller.BlogController.TermController();
                    termController.addTerm(sr);
                   
                }
            }


        }
        public Controller.UserController.WorkingTimeController workingTimeController;
        public Controller.BlogController.TermController termController;
    }
}


