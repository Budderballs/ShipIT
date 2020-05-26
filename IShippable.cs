using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIT
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
