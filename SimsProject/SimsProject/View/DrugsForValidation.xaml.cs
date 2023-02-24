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
    /// Interaction logic for DrugsForValidation.xaml
    /// </summary>
    public partial class DrugsForValidation : Window
    {
        XmlReaderWriter rw = new XmlReaderWriter();

        Doctor trDoctor;

        List<Drug> lista;
        List<Ratio> listaR;
        public DrugsForValidation()
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
            lista = new List<Drug>();
            List<Drug> tempList = rw.DeSerializeObject<List<Drug>>("../../Fajlovi/lijekovi.xml");
            foreach (var drug in tempList)
            {

                lista.Add(drug);

            }

            listaR = new List<Ratio>();
            List<Drug> tempList2 = rw.DeSerializeObject<List<Drug>>("../../Fajlovi/ratio.xml");
            foreach (var drug in tempList)
            {

                lista.Add(drug);

            }


            xLijekovi.ItemsSource = lista;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Drug d = (Drug)xLijekovi.SelectedItem;

            //d.state = "APPROVED";
            /*foreach(var i in lista)
            {
                if(d.name.Equals(i.name))
                {
                    // d.state = "APPROVED";
                    lista.Remove(i);
                }
            }*/
        }
    }
}
