using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIT
{
    class Crackers : IShippable
    {
        public decimal ShipCost => 0.57m;

        public string Product => "Crackers";
    }
}
