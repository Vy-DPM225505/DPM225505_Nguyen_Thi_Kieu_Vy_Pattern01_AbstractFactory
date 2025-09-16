using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal01_AbstractFactory
{
    class Family
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        // Constructor
        public Family(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }
        public void RunFoodChain()
        {
            _carnivore.taller(_herbivore);
        }
    }
}
