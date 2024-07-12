using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP02.inheritance
{
    internal class parent
    {

        #region properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

    
        public parent(int _x , int _y)
        {
            x = _x;
            y = _y;
        }




        #region method
        public override string ToString()
        {
            return $" x : {x} \n y {y}";

        }

        public int product()
        {

            return x * y;
        
        }

        #endregion



    }
}
