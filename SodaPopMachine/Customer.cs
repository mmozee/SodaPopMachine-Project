using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    public class Customer
    {
        public Wallet wallet;
        public BackPack backPack;
        
        static List<Can> cans;

        public Customer()
        {
            wallet = new Wallet();
            backPack = new BackPack();
            cans = new List<Can>();
        }
        //public void GetMoney(double totalCost)
        //{

        //}
        //public void SelectSodaFromMachine()
        //{
        //    string chosenSoda = UserInterface.SelectSodaType();
        //    if(chosenSoda == "Cola")
        //    {
        //        GetMoney();
        //    }
        //    bool correctChange = false;
        //    while (correctChange == false;)
        //    if (soda == "Cola" && payment = .35)
        //    {
        //        for (int i = 0; i < 7; i--)
        //        {
        //            Can cola = new Cola();
                   
        //            cans.Add(cola);

        //        }
        //    }
        //    else if (soda == "RootBeer" && payment = .60)
        //    {
        //        for (int i = 0; i < 11; i++)
        //        {
        //            Can rbeer = new RootBeer();
        //            SodaMachine.inventory.Remove(rbeer);
        //            cans.Add(rbeer);
        //        }
        //    }
        //    else if (soda == "OrangeSoda" && payment = .06)
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Can orange = new OrangeSoda();
        //            inventory.Add(orange);
        //            cans.Add(orange);

        //        }
        //    }
        //    else
        //    {
        //        correctChange = false;
        //    }


        
            

        
    }


    
    
        

    
}
