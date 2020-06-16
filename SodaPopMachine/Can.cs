using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    public abstract class Can
    {// member variable - Has A
        public List<Can> inventory;
        protected double cost;
        protected double Cost;
        protected string name;

        public Can()
        {
            inventory = new List<Can>();
            

        }
    }
    
    

    
}




// member methods - Can Do
