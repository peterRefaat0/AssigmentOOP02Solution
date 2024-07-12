using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP02.inheritance
{
    internal class child : parent
    {

        public int z { get; set; }

        public child(int _x , int _y , int _z) : base(_x , _y)
        {
             z = _z;
        }
    }
}
