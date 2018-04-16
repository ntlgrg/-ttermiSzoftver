using ÉttermiSzoftver_DAL;
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

namespace ÉttermiSzoftver
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        private cnÉttermiSzoftver cnEttermiSzoftver = new cnÉttermiSzoftver();
        private Beleptetes b = new Beleptetes();
        private string n;

        public delegate void OnBelep();
        public static event OnBelep OnLogin;

        public ucLogin()
        {
            InitializeComponent();
        }

        // -----------------------------------------------------------------------------------------------------
        // Regisztráció - A gombra kattintva elmentjük a felhasználót az adatbázisba
        // -----------------------------------------------------------------------------------------------------
        private void btBelepes_Click(object sender, RoutedEventArgs e)
        {
            string f = tbNev.Text; // Felhasznalo nev
            string j = pbJelszo.Password; // Jelszó

           /* var Fe = from x in cnEttermiSzoftver.enSzemelyek // Megkeressük az adatbázisban a felhasználót
                     where f == x.BejelentkezesiNev
                     select x.BejelentkezesiNev;

            var Je = from x in cnEttermiSzoftver.enSzemelyek // Megkeressük az adatbázisban a jelszót
                     where f == x.BejelentkezesiNev
                     select x.Jelszo;
*/
            // ADMIN belépés
            if (f == "admin")
            {
                if (j == "admin")
                {
                    //b.Felhasz = 1;
                    b.Admin = true;

                    if (OnLogin != null)
                        OnLogin();
                    MessageBox.Show("Belépés sikeres!\n\nÜdvözlünk ADMIN!");
                }
                else MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }

            // Felhasználó belépés
            else if (Fe.FirstOrDefault() == f)
            {
                if (Je.FirstOrDefault() == j)
                {
                    var Fe2 = from x in cnEttermiSzoftver.enSzemelyek // Megkeressük az adatbázisban a felhasználót
                              where f == x.BejelentkezesiNev
                              select x.Id;

                    b.Admin = false;

                    OnLogin();

                    b.Felhasz = (from x in cnEttermiSzoftver.enSzemelyek where f == x.Nev select x.Id).FirstOrDefault(); // Felhasználó ID lekérdezése

                    n = (from x in cnEttermiSzoftver.enSzemelyek where f == x.Nev select x.Pozicio).FirstOrDefault(); // Felhasználó nevének lekérdezése
                    MessageBox.Show("Belépés sikeres!\n\nÜdvözlünk " + n);

                }
                else MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }

            else MessageBox.Show("Hibás felhasználónév vagy jelszó!");
        }

    }
}
