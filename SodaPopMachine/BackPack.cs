using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    public class BackPack
    {
        public List<Can> cans;

        public BackPack()
        {
            cans = new List<Can>(0){ new OrangeSoda(), new Cola(), new RootBeer()};
        }
       
    }
}
