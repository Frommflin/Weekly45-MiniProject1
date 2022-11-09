using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace W45_Mini1
{
    internal class Methods
    {
        public static void ShowAssets(List<Hardware> assets)
        {
            List<Hardware> orderedAssets = assets.OrderBy(h => h.Type).ThenBy(x => x.DateOfPurchase).ToList();
            DateTime maxLifeTime = DateTime.Now.AddYears(-3);

            Console.WriteLine();
            Console.WriteLine();

            // Printing out sorted list to user
            Console.WriteLine("Type".PadRight(20) + "Brand".PadRight(20) + "Model".PadRight(20) + "Price (USD)".PadRight(20) + "Date of purchase");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            foreach (Hardware hardware in orderedAssets)
            {
                TimeSpan diff = hardware.DateOfPurchase - maxLifeTime;
                if (diff.Days < 90)  // Check if date of purchase is less than 3 months away from 3 years and make RED
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(hardware.Type.PadRight(20) + hardware.Brand.PadRight(20) + hardware.Model.PadRight(20) + hardware.Price.ToString().PadRight(20) + hardware.DateOfPurchase.ToString("yyyy-MM-dd"));
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static Hardware AddAssets(string inputtype)
        {
            string input;
            string type;
            string brand;
            string model;
            int price;
            DateTime date;

            if(inputtype == "c")
            {
                type = "Computer";
            }
            else if(inputtype == "l")
            {
                type = "Laptop";
            }
            else
            {
                type = "Phone";
            }

            Console.WriteLine($"Follow instructions to add new company {type.ToLower()}.");


            // do-while loops preventing string fields from being left empty
            do
            {
                Console.Write("Brand: ");
                input = Console.ReadLine();
                input.Trim();

                if (String.IsNullOrEmpty(input) || input == " ")
                {
                    Console.WriteLine("Brand cannot be left empty");
                    brand = "";
                }
                else
                {
                    brand = input;
                }
            } while (brand == "");

            do
            {
                Console.Write("Model: ");
                input = Console.ReadLine();
                input.Trim();

                if (String.IsNullOrEmpty(input) || input == " ")
                {
                    Console.WriteLine("Model cannot be left empty");
                    model = "";
                }
                else
                {
                    model = input;
                }
            } while (model == "");

            // do-while loop preventing price from being 0 or a non-integer
            do
            {
                Console.Write("Price: ");
                input = Console.ReadLine();
                input.Trim();

                if (String.IsNullOrEmpty(input) || input == " ")
                {
                    Console.WriteLine("Field can't be left empty!");
                    price = 0;
                }
                else if (int.TryParse(input, out int value))
                {
                    if (value == 0)
                    {
                        Console.WriteLine("Price cannot be 0!");
                    }
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price has to be a number!");
                    price = 0;
                }

            } while (price == 0);

            // do-while loop preventing date of purchase from being a non-date
            do
            {
                Console.Write("Date of purchase (yyyy-mm-dd): ");
                input = Console.ReadLine();
                input.Trim();

                if (String.IsNullOrEmpty(input) || input == " ")
                {
                    Console.WriteLine("Field can't be left empty!");
                    date = new DateTime(0001, 01, 01);
                }
                else if (DateTime.TryParse(input, out DateTime purchased))
                {
                    date = purchased;
                }
                else
                {
                    Console.WriteLine("Invalid date");
                    date = new DateTime(0001, 01, 01);
                }
            } while (date == new DateTime(0001, 01, 01));

            if (inputtype == "c")
            {
                Computer asset = new Computer(type, brand, model, price, date);
                return asset;
            }
            else if (inputtype == "l")
            {
                Laptop asset = new Laptop(type, brand, model, price, date);
                return asset;
            }
            else
            {
                Phone asset = new Phone(type, brand, model, price, date);
                return asset;
            }
        }
    }
}
