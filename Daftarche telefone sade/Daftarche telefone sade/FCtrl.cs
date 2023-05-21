using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daftarche_telefone_sade
{
    class FCtrl
    {
        public Tel[] Tels = new Tel[100];
        int i = 0;
        public FCtrl() { }
        public void Add(Tel tel)
        {
            Tels[i] = tel;
            i++;
        } 
        public int k = 0;
        public Tel[] search(Person person)
        {
            Tel[] tels = new Tel[10];

            for(int j = 0; j < i; j++)
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
