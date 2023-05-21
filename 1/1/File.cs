using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1
{
    class File
    {
        ArrayList arrayList = new ArrayList();
        public void Save(Ctrl ctrl)
        {
            arrayList.Add(ctrl);
        }
        public Ctrl Show(int index)
        {
            return (Ctrl)arrayList[index];
        }
        public int countList()
        {
            return arrayList.Count;
        }
    }
}
