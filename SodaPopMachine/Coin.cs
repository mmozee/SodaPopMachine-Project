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
        public double Value
        {
            get
            {
                return value;
            }
        }
        public double value;
        

        public Coin()
        {
            
        }
    }
}
