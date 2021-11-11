using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3
{
    public class Cirkel : Teckning
    {

        public double  _Radius { get; set; }


        public Cirkel( )
        {
            this._Radius = 4;

        }

        public override double Area()
        {
            return _Radius * _Radius * Math.PI;
        }
    }


}
