using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Ctrl
    {
        public Mosafer Mosafer;
        public Otagh Otagh;
        public EjareKardan EjareKardan;
       
        public void Save(Mosafer m)
        {
            Mosafer = m;
        }
        public void Save(Otagh o)
        {
            Otagh = o;
        }
        public void Save(EjareKardan e)
        {
            EjareKardan = e;
        }
        public Ctrl Show()
        {
            return this;
        }
    }
}
