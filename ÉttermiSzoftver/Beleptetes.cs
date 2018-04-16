using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÉttermiSzoftver
{
    public class Beleptetes
    {
        private static int _Felhasznalo; // Ebben tároljuk a felhasználó azonosítóját

        private static bool _admin; // Ebben tároljuk a felhasználó azonosítóját

        public int Felhasz
        {
            get
            {
                return _Felhasznalo;
            }
            set
            {
                _Felhasznalo = value;
            }
        }

        public bool Admin
        {
            get
            {
                return _admin;
            }

            set
            {
                _admin = value;
            }
        }
    }
}
}
