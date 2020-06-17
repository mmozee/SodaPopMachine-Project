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
        static List<Coin> payment;
        static List<Can> currentInventory;
        static void SelectSodaType()
        {
            Console.WriteLine($"Please select you soda - OrangeSoda, RootBeer, or Cola");
            string soda = Console.ReadLine();
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
        public static void PickCoinsforSodaMachine()
        {
            Console.WriteLine($"What Coins are you selecting for your soda purchase");
            payment = new List<Coin>() { new Quarter(), new Dime(), new Nickel(), new Penny()};

            for (int i = 0; i < 0; i++)
            {
                Coin quarter = new Quarter();
                payment.Add(quarter);
                
            }
            for (int i = 0; i < 0; i++)
            {
                Coin dime = new Dime();
                payment.Add(dime);
            }
            for (int i = 0; i < 0; i++)
            {
                Coin nickel = new Nickel();
                payment.Add(nickel);

            }
            for (int i = 0; i < 0; i++)
            {
                Coin penny = new Penny();
                payment.Add(penny);
            }
        }
        public static void LeftInSodaMachine()
        {
            Console.WriteLine($"What ya getting{new OrangeSoda(),new RootBeer(), new Cola()}");

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
        




        
    }
}
