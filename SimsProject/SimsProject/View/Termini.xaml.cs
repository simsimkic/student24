using Model.Employee;
using Model.Examination;
using Model.User;
using Service.TermService;
using SimsProject.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for Termini.xaml
    /// </summary>
    public partial class Termini : Window
    {
        XmlReaderWriter rw = new XmlReaderWriter();
        public Controller.ExaminationController.ExaminationController examController;
        public Controller.BlogController.TermController termController;

        public String dateString { get; set; }
        public String dateString1 { get; set; }
        public DateTime datum1 { get; set; }
        public DateTime datum2 { get; set; }

        public List<Period> srLista { get; set; }
        public List<Period> srLista1 { get; set; }

        public List<Term> termList { get; set; }
        public Period sR { get; set; }

        Doctor lj;
        DateTime d;
        Patient p;
        public Termini()
        {
            InitializeComponent();
            this.DataContext = this;

        }
        private void setButtonVisibility()
        {
            if (xTerminiData.SelectedItem == null )
            {
                Zakazi.IsEnabled = false;
            }
            else
            {
                Zakazi.IsEnabled = true;
            }
        }
        public Termini(Doctor doc,DateTime dat,Patient pat)
        {
            InitializeComponent();
            this.DataContext = this;

            lj = doc;
            d = dat;
            p = pat;

           
            srLista = new List<Period>();
          
            termList = new List<Term>();

            
            termController = new Controller.BlogController.TermController();
            srLista= termController.searchTerm(lj.userName, d);

            if (srLista != null)
            {
                Zakazi.IsEnabled = true;
            }
           
            foreach (var sr in srLista)
            {
                String noviDatum = sr.day.ToString();
                String[] dijelovi = noviDatum.Split(' ');
                String datumcic = dijelovi[0];

                //dateString = datumcic +sr.startTime + ":00:00 AM";
                dateString =datumcic+ " " +sr.startTime+ ":00 AM";
                dateString1 =datumcic+ " " + sr.endTime + ":00 AM";
                
                 datum1 = ConvertToDateTime(dateString);
                 datum2 = ConvertToDateTime(dateString1);
                 Term ajde = new Term
                 {
                     start = datum1,
                     end = datum2

                 };

                 termList.Add(ajde);

            }
            xTerminiData.ItemsSource =termList;
        }
        

        private void Zakazi_Click(object sender, RoutedEventArgs e)
        {
            examController = new Controller.ExaminationController.ExaminationController();
           
            //Poslednji id pregleda
            int num = 0;
            num = examController.getLastExaminationId();

            
            Examination inf = new Examination
            {
                doctor = this.lj,
                patient = this.p,
                Id = ++num,
                term =(Term)xTerminiData.SelectedItem

            };

            
            examController.ScheduleExamination(inf);


            var p = new MojiPregledi();
            p.Show();

            this.Close();
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


        private void xTerminiData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            setButtonVisibility();
        }
    }
}
