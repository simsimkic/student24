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
    /// Interaction logic for PocetnaUpravnika.xaml
    /// </summary>
    public partial class PocetnaUpravnika : Window
    {
        public PocetnaUpravnika()
        {
            InitializeComponent();
        }

        private void registrujLjekara_Click(object sender, RoutedEventArgs e)
        {
            var l = new RegistracijaLjekara();
            l.Show();
            this.Close();
        }

        private void registrujSekretara_Click(object sender, RoutedEventArgs e)
        {
            var s = new RegistracijaSekretara();
            s.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new RadnoVrijeme();
            s.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new UnosLijeka();
            s.Show();

        }
    }
}
