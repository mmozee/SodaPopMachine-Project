using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    static class UserInterface
    {
        static void SelectSodaType()
        {
            Console.WriteLine($"Please select you soda - OrangeSoda, RootBeer, or Cola");
            string soda = Console.ReadLine();
        }
        static void WhatsInYourWallet()
        {
            Console.WriteLine($"How much in Quarters do you have in your Wallet");
            double quartersInWallet = double.Parse(Console.ReadLine());
            Console.WriteLine($"How much in Dimes do you have in your Wallet");
            double dimesInWallet = double.Parse(Console.ReadLine());
            Console.WriteLine($"How much in Nickels do you have in your Wallet");
            double nickelsInWallet = double.Parse(Console.ReadLine());
            Console.WriteLine($"How much in Pennies do you have in your Wallet");
            double penniesInWallet = double.Parse(Console.ReadLine());
        }
        static void WhatsinYourBackpack()
        {
            Console.WriteLine($"How many OrangeSodas do you have");
            int oSodasinBackpack = int.Parse(Console.ReadLine());
            Console.WriteLine($"How many OrangeSodas do you have");
            int rbSodasinBackpack = int.Parse(Console.ReadLine());
            Console.WriteLine($"How many OrangeSodas do you have");
            int cSodasinBackpack = int.Parse(Console.ReadLine());

        }
        




        
    }
}
