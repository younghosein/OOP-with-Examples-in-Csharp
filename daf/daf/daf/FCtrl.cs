using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daf
{
    class FCtrl
    {
        public Tel[] Tels = new Tel[100];
        public int i = 0;
        public void Add(Tel tel)
        {
            Tels[i++] = tel;

        }
        public void Del()
        {
            for (int j = 0; j < i; j++)
            {

                Tels[j] = null;
            }
        }
        public int k = 0;
        public Tel[] search(Person person)
        {
            Tel[] tels = new Tel[10];

            for (int j = 0; j < i; j++)
            {
                if (Tels[j].person.Name == person.Name)
                {
                    tels[k] = Tels[j];
                    k++;
                }
            }
            return tels;
        }
    }
}
