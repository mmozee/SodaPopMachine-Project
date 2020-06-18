using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    class Simulation
    {
        public SodaMachine sodaMachine;
        public Customer customer;


        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
        }
        public void RunSimulation()
        {
            sodaMachine.Transaction(customer);
        }
    }
}
