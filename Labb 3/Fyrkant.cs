using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3
{
    public class Fyrkant : Teckning
    {
        public double _Length { get; set; }



        public Fyrkant()
        {
            this._Length = 4;
            
        }
        public override double Area()
        {
            return _Length * _Length;
        }
    }
}
