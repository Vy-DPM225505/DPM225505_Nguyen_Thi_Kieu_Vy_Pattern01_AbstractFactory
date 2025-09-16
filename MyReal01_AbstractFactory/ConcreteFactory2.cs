using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal01_AbstractFactory
{
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Borther();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Sister();
        }
    }
}
