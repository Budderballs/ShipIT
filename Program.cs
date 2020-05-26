using System;
using System.Collections.Generic;

namespace ShipIT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShippable> productList = new List<IShippable>();
            bool buying = true;
            while (buying)
            {
                menu.menuStrings();
                menu.addingItems(productList);
            }
        }
    }
}
