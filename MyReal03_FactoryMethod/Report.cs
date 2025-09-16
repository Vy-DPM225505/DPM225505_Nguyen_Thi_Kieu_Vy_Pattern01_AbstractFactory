using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal03_FactoryMethod
{
    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new Introduction());
            Pages.Add(new Results());
            Pages.Add(new Conclusion());
            Pages.Add(new Bibliography());
        }
    }
}
