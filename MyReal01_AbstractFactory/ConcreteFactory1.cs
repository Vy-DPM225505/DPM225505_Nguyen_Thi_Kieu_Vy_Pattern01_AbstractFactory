using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal01_AbstractFactory
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Father();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Mother();
        }
    }
}
