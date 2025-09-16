using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal01_AbstractFactory
{
    class Mother : Carnivore
    {
        public override void taller(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
              " taller " + h.GetType().Name);
        }
    }
}
