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
    /// Interaction logic for PocetnaSekretar.xaml
    /// </summary>
    public partial class PocetnaSekretar : Window
    {
        public PocetnaSekretar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var p = new RegistracijaPacijenta();
            p.Show();

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var p = new GuestNalog();
            p.Show();

            this.Close();
        }
    }
}
