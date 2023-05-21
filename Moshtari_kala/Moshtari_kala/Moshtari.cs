using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Moshtari_kala
{
    class Moshtari
    {
        public string name;
        public int tedad;
        public int qeymat;
        public int pol;
        public int result()
        {
            pol = tedad * qeymat;
            return pol;
        }
    }
}
