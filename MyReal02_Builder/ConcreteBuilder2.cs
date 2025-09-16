using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReal02_Builder
{
    class XeDapBuilder : VehicleBuilder
    {
        public XeDapBuilder()
        {
            vehicle = new Vehicle("XeDap");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "XeDap Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = " 0 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "0";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
}
