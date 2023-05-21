using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class EjareKardan
    {
        public Otagh Otagh;
        public Mosafer Mos;
        public EjareKardan(Otagh o, Mosafer m)
        {
            Otagh = o;
            Mos = m;
        }
        public Otagh showOtagh()
        {
            return Otagh;
        }
        public Mosafer showMosafer()
        {
            return Mos;
        }
    }
}
