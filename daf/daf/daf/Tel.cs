using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daf
{
    class Tel
    {
        public Person person;
        public string NO;
        public Tel(string NO,Person person)
        {
            this.NO = NO;
            this.person = person;
        }
        public Tel(string NO)
        {
            this.NO = NO;
        }
    }
}
