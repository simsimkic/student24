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

namespace SimsProject
{
    /// <summary>
    /// Interaction logic for Pregledi1.xaml
    /// </summary>
    public partial class Pregledi1 : Window
    {
        XmlReaderWriter rw = new XmlReaderWriter();

        Doctor trDoctor;



        List<Examination> lista;

        public Pregledi1()
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

            lista = new List<Examination>();
            List<Examination> tempList = rw.DeSerializeObject<List<Examination>>("../../Fajlovi/pregledi.xml");
            foreach (var pregled in tempList)
            {
                if (pregled.doctor.userName.Equals(trDoctor.userName))
                {
                    lista.Add(pregled);
                }
            }


            xMojiPregledi.ItemsSource = lista;

        }
    }
}
