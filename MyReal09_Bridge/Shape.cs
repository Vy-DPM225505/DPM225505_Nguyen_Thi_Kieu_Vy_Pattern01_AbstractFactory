using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal09_Bridge
{
    abstract class Shape
    {
        public Color color { get; set; }

        public string GetColor()
        {
            return color.GetColor();
        }
    }
}
