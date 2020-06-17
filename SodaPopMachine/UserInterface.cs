using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    public static class UserInterface
    {
        
        static List<Can> currentInventory;
        public static string SelectSodaType()
        {
            Console.WriteLine("Please select you soda - OrangeSoda, RootBeer, or Cola");
            string soda = Console.ReadLine();
            return soda;

        }
       public static void WhatsInYourWallet()
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
        public static void WhatsinYourBackpack()
        {
            Console.WriteLine($"How many OrangeSodas do you have");
            int oSodasinBackpack = int.Parse(Console.ReadLine());
            Console.WriteLine($"How many OrangeSodas do you have");
            int rbSodasinBackpack = int.Parse(Console.ReadLine());
            Console.WriteLine($"How many OrangeSodas do you have");
            int cSodasinBackpack = int.Parse(Console.ReadLine());

        }
        public static void SelectCoins()
        {
            Console.WriteLine($"What Coins are you selecting for your soda purchase");
            
            
        }
        public static void LeftInSodaMachine()
        {
            Console.WriteLine("What ya getting{OrangeSoda, RootBeer, Cola()");

            currentInventory = new List<Can>(){ new OrangeSoda(), new RootBeer(), new Cola()});
            {
                for (int i = 0; i < 5; i--)
                {
                    Can orange = new OrangeSoda();
                    currentInventory.Remove(orange);

                }
                for (int i = 0; i < 11; i--)
                {
                    Can rbeer = new RootBeer();
                    currentInventory.Remove(rbeer);
                }
                for (int i = 0; i < 7; i--)
                {
                    Can cola = new Cola();
                    currentInventory.Remove(cola);
                }  
            }  
        }
        public static void 




        
    }
}
