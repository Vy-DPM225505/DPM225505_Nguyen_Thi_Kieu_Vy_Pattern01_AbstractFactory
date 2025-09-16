using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal03_FactoryMethod
{
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new Skills());
            Pages.Add(new Education());
            Pages.Add(new Name());
        }
    }
}
