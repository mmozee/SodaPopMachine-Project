using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    public abstract class Coin
    {//member variable
        public string name;
        protected double Value;
        protected double value;
        public List<Coin>register;

        public Coin()
        {
            register = new List<Coin>();
        }
    }
}
