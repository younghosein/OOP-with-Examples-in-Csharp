using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Motahel : Mosafer
    {
        private int ChildNumber;
        public Motahel(int childnumber, string name) : base(name)
        {
            ChildNumber = childnumber;
        }

        public int showChildNumber()
        {
            return ChildNumber;
        }
    }
}
