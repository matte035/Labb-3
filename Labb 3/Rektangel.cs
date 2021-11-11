using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3
{
    public class Rektangel : Teckning
    {
        public double _height { get; set; }
        public double _width { get; set; }
        public Rektangel()
        {
            this._width = 10;
            this._height = 15;
        }

        public override double Area()
        {
            return _height * _width;
        }
    }
}
