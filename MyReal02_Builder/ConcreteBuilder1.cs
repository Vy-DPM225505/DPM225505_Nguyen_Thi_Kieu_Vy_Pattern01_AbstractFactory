using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal02_Builder
{
    class OtoCycleBuilder : VehicleBuilder
    {
        public OtoCycleBuilder()
        {
            vehicle = new Vehicle("OtoCycle");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "OtoCycle Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "1000 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "3";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }
}
