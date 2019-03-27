using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    class Indexator
    {
        public int[] array=new int[10];
        public int this[int i]
        {
            get
            {

                return array[i];
            }
            set
            {
                array[i] = value * value;
            }
           
        }
    }
}
