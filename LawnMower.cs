using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIT
{
    class LawnMower : IShippable
    {
        public decimal ShipCost => 24.00m;

        public string Product => "Lawn Mower";
    }
}
