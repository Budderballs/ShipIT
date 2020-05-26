using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIT
{
    class Bicycle : IShippable
    {
        public decimal ShipCost => 20.50m;

        public string Product => "Bicycle";
    }
}
