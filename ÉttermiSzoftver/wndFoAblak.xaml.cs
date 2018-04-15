using System;
using System.Collections.Generic;
using System.IO;
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

namespace ÉttermiSzoftver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class wndFoAblak : Window
    {
        public wndFoAblak()
        {
            InitializeComponent();
            var DataDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName) + "\\Telefonszamok_DAL_Konzol";
            AppDomain.CurrentDomain.SetData("DataDirectory", DataDir);
            var s = AppDomain.CurrentDomain.GetData("DataDirectory");

        }

        private void miFelvetel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miAllapot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miSzamla_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miBejelentkezes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miLegnepszerubb_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void miPincer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miKijelentkezes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miKimutatas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
