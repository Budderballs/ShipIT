using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace ShipIT
{
    class menu
    {
        //Main menu mumbo jumbo
        public static void menuStrings()
        {
            Console.WriteLine("1: Add a Bicycle to the shipment");
            Console.WriteLine("2: Add a Lawn Mower to the Shipment");
            Console.WriteLine("3: Add a Baseball Glove to the shipment");
            Console.WriteLine("4: Add Crackers to the shipment");
            Console.WriteLine("5: List Shipment Items");
            Console.WriteLine("6: Compute Shipping Charges");
        }

        public static void addingItems(List<IShippable> productList)
        {
            
            string itemNum = Console.ReadLine();

            switch (itemNum)
            {
                case "1":

                    productList.Add(new Bicycle());
                    Console.WriteLine("1 Bicycle added to shipment");
                    Console.WriteLine();
                    break;
                case "2":

                    productList.Add(new LawnMower());
                    Console.WriteLine("1 Lawn mower added to shipment");
                    Console.WriteLine();
                    break;
                case "3":

                    productList.Add(new BBGlove());
                    Console.WriteLine("1 Baseball glove added to shipment");
                    Console.WriteLine();
                    break;
                case "4":

                    productList.Add(new Crackers());
                    Console.WriteLine("1 Crackers added to shipment");
                    Console.WriteLine();
                    break;
                case "5":
                    // Starting variables
                    int bNum = 0;
                    int lNum = 0;
                    int bGNum = 0;
                    int cNum = 0;
                    //Adds to list
                    foreach (IShippable products in productList)
                    {
                        if (products.Product.Equals("Bicycle"))
                        { bNum++; }
                        else if (products.Product.Equals("Lawn Mower"))
                        { lNum++; }
                        else if (products.Product.Equals("Baseball Glove"))
                        { bGNum++; }
                        else if (products.Product.Equals("Crackers"))
                        { cNum++; }
                    }

                    // Nothing shipping
                    if (bNum == 0 && lNum == 0 && bGNum == 0 && cNum == 0)
                    {
                        Console.WriteLine("You didn't add anything to the list pal :)");
                    }
                    else
                    {
                        // Bikes
                        if (bNum == 1)
                        {
                            Console.WriteLine(bNum + " Bicycle");
                            Console.WriteLine();
                        }
                        else if (bNum > 1)
                        {
                            Console.WriteLine(bNum + " Bicycles");
                            Console.WriteLine();
                        }
                        // Lawn mowers
                        if (lNum == 1)
                        {
                            Console.WriteLine(lNum + " Lawn Mower");
                            Console.WriteLine();
                        }
                        else if (lNum > 1)
                        {
                            Console.WriteLine(lNum + " Lawn Mowers");
                            Console.WriteLine();
                        }
                        // Baseball gloves
                        if (bGNum == 1)
                        {
                            Console.WriteLine(bGNum + " Baseball Glove");
                            Console.WriteLine();
                        }
                        else if (bGNum > 1)
                        {
                            Console.WriteLine(bGNum + " Baseball Gloves");
                            Console.WriteLine();
                        }
                        // Crackers
                        if (cNum > 0)
                        {
                            Console.WriteLine(cNum + " Crackers");
                            Console.WriteLine();
                        }
                    }
                    break;

                case "6":

                    decimal decimalMath = 0m;

                    //The math
                    foreach (IShippable productMath in productList)
                    {
                        decimalMath = decimalMath + productMath.ShipCost;
                    }
                    if (decimalMath == 0)
                    {
                        Console.WriteLine("You aren't shipping anything buddy :)");
                    }
                    else
                    {
                        Console.WriteLine("The total shipping cost is: $" + decimalMath);
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    break;
                default:
                    Console.WriteLine("Pick a valid number dumbo :)");
                    break;
            }
        }
    }
}
