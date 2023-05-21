using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daftarche_telefone_sade
{
    class Tel
    {
        public Person person;
        public string No;
        public Tel(string No,Person person)
        {
            this.No = No;
            this.person = person;
        }
    }
}
