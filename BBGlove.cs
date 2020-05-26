using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIT
{
    class BBGlove : IShippable
    {
        public decimal ShipCost => 3.23m;

        public string Product => "Baseball Glove";
    }
}
