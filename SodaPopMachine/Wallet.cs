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
        Card card;
            
        public Wallet()
        {
            coins = new List<Coin>(5);
            card = new Card();


        }
    }
}
