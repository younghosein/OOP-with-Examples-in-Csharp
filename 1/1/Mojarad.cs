using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Mojarad : Mosafer
    {
        private int Age;

        public Mojarad(int age, string name) : base(name)
        {
            Age = age;
        }

        public int showAge()
        {
            return Age;
        }
    }
}
