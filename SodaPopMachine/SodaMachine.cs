using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaPopMachine
{
    public class SodaMachine
    {
        public List<Can> inventory;
        

        public List<Coin> register;
        public SodaMachine()
        {
            inventory = new List<Can>() { new OrangeSoda(), new RootBeer(), new Cola() };

            for (int i = 0; i < 5; i++)
            {
                Can orange = new OrangeSoda();
                inventory.Add(orange);

            }
            for (int i = 0; i < 11; i++)
            {
                Can rbeer = new RootBeer();
                inventory.Add(rbeer);
            }
            for (int i = 0; i < 7; i++)
            {
                Can cola = new Cola();
                inventory.Add(cola);
            }

            register = new List<Coin>() { new Quarter(), new Dime(), new Nickel(), new Penny() };

            for (int i = 0; i < 20; i++)
            {
                Coin quarter = new Quarter();
                register.Add(quarter);

            }
            for (int i = 0; i < 10; i++)
            {
                Coin dime = new Dime();
                register.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Coin nickel = new Nickel();
                register.Add(nickel);

            }
            for (int i = 0; i < 50; i++)
            {
                Coin penny = new Penny();
                register.Add(penny);
            }

        }
        public void Transaction()
        {
            Can SodaThatWasSelected = SelectSodaForPurchase();
            DisplayCost(SodaThatWasSelected);
            GetPayment;
            


        }
        public Can SelectSodaForPurchase()
        {
            string chosenSoda = UserInterface.SelectSodaType();
            for (int i = 0; i < inventory.Count; i++)
            {
                if(inventory[i].name  == chosenSoda)
                {
                    return inventory[i];
                }
            }
            Console.WriteLine("We couldnt find that soda, Select Another?");

            return SelectSodaForPurchase();
            

        }
        public void DisplayCost(Can SodaToPurchase)
        {
            Console.WriteLine(SodaToPurchase.Cost);
        }
        public void GetPayment()
        {
            Console.WriteLine($"Please deposit money in slot below");
            Console.WriteLine("How many quarters");
            double qCount = double.Parse(Console.ReadLine());
            double qChange = (qCount * .25);
            Console.WriteLine("How many dimes");
            double dCount = double.Parse(Console.ReadLine());
            double dChange = (dCount * .10);
            Console.WriteLine("How many nickels");
            double nCount = double.Parse(Console.ReadLine());
            double nChange = (nCount * .05);
            Console.WriteLine("How many pennies");
            double pCount = double.Parse(Console.ReadLine());
            double pChange = (pCount * .01);

            double tChangeCount = (qChange + dChange + nChange + pChange);
        }
        public void VerifyPayment(double tChangeCount)
        {
            bool isInWallet = false;
            while (isInWallet==false)
            {
                if(tChangeCount <= Wallet.);
            }
            {
                
            }

        }
        public void RefundMoney()
        {

        }
        public void GiveChange()
        {

        }
        public void DispenseSoda()
        {

        }
       
    }
    
            
}
