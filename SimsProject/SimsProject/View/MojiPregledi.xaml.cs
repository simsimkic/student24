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
    /// Interaction logic for MojiPregledi.xaml
    /// </summary>
    public partial class MojiPregledi : Window
    {
        XmlReaderWriter rw = new XmlReaderWriter();

        Patient trPacijent;



        List<Examination> lista;
        public MojiPregledi()
        {
            InitializeComponent();
            this.DataContext = this;

            User prKor = new User();
            User temp = rw.DeSerializeObject<User>("../../Fajlovi/korisnik.xml");
            prKor = temp;

            trPacijent = new Patient();
            List<Patient> pacijenti = rw.DeSerializeObject<List<Patient>>("../../Fajlovi/pacijenti.xml");
            foreach (var p in pacijenti)
            {
                if (prKor.userName.Equals(p.userName))
                {
                    trPacijent = p;
                }
            }

            lista = new List<Examination>();
            List<Examination> tempList = rw.DeSerializeObject<List<Examination>>("../../Fajlovi/pregledi.xml");
            foreach(var pregled in tempList)
            {
                if (pregled.patient.userName.Equals(trPacijent.userName))
                {
                    lista.Add(pregled);
                }
            }
           
           
            xMojiPregledi.ItemsSource = lista;
        }
    }
}
