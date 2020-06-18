using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    public class Wallet
    { 
        public List<Coin> coins;
        public double tCoins;
        public Card card;
            
        public Wallet()
        {
            card = new Card();
            //tCoins = double.Parse();
            coins = new List<Coin>() { new Quarter(), new Dime(), new Nickel(), new Penny() };

            for (int i = 0; i < 14; i++)
            {
                Coin quarter = new Quarter();
                coins.Add(quarter);

            }
            for (int i = 0; i < 13; i++)
            {
                Coin dime = new Dime();
                coins.Add(dime);
            }
            for (int i = 0; i < 2; i++)
            {
                Coin nickel = new Nickel();
                coins.Add(nickel);

            }
            for (int i = 0; i < 11; i++)
            {
                Coin penny = new Penny();
                coins.Add(penny);
            }
        }

    }
}
