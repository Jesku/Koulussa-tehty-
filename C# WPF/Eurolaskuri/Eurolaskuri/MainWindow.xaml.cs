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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Eurolaskuri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double luku_uusi1, muunnos = 0; //huomaa, että joudut antamaan muunnos
                                            //muuttujalle oletusarvon
            try
            {
                luku_uusi1 = Double.Parse(luku1.Text); //muutetaan teksti double numeroksi
                                                       //Tarkistetaan kumpi Radio Button on valittuna, ja suoritetaan lasku
                if ((bool)euro.IsChecked) muunnos = luku_uusi1 * 5.94573;
                if ((bool)markka.IsChecked) muunnos = luku_uusi1 / 5.94573;
            }
            catch { }

            Tulos.Text = muunnos.ToString(); //tulostetaan vastaus
        }
    }
}
