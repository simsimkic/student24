using Model.Examination;
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
    /// Interaction logic for UnosLijeka.xaml
    /// </summary>
    /// 
    public partial class UnosLijeka : Window
    {
        XmlReaderWriter rw = new XmlReaderWriter();

        String sastojci = null;
        List<String> sastojciList;
        List<Ratio> odnosiLista = new List<Ratio>();
        List<Drug> lijekoviLista = new List<Drug>();

        public UnosLijeka()
        {
            InitializeComponent();
            this.DataContext = this;
            /////////////////////////////////////
            ///

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sastojciList = new List<String>();
            sastojci = xSastojci.Text;
            String[] sastojci1 = sastojci.Split(',');

            foreach (var i in sastojci1)
            {
                sastojciList.Add(i);
            }

            foreach (var i in sastojciList)
            {
                //odnosiLista= new List<Ratio>();
                String[] dijelovi = i.Split('-');


                Ratio ratio = new Ratio
                {
                    nameIngredient = dijelovi[0],
                    percent = dijelovi[1]


                };
                odnosiLista.Add(ratio);
                /* List<Ratio> ratioo = new List<Ratio>();
                 List<Ratio> ratioo = rw.DeSerializeObject<List<Ratio>>("../../Fajlovi/ratio.xml");
                 ratioo.Add(ratio);
                 rw.SerializeObject<List<Drug>>(ratioo, "../../Fajlovi/ratio.xml");
                 */


            }



            Drug drug = new Drug
            {

                name = xIme.Text,
                state = "FOR VALIDATION",
                id = 0,
                ratio = odnosiLista

            };
            odnosiLista = new List<Ratio>();
            List<Drug> drugs = rw.DeSerializeObject<List<Drug>>("../../Fajlovi/lijekovi.xml");
            drugs.Add(drug);
            rw.SerializeObject<List<Drug>>(drugs, "../../Fajlovi/lijekovi.xml");

            //kad kliknes na potvrdi puca ???


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var s = new DrugsForValidation();
            s.Show();
        }
    }
}
