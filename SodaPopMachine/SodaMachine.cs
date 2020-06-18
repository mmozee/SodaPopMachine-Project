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
       // static List<Coin> payment;


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
        public void Transaction(Customer customer)
        {
            Can SodaThatWasSelected = SelectSodaForPurchase();
            DisplayCost(SodaThatWasSelected);
            List<Coin> payment = GetPayment(customer);
            VerifyPayment(payment);
            


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
        public List<Coin> DisplayCost(Can SodaToPurchase)
        {
            List<Coin> display = new List<Coin>();
            Console.WriteLine(SodaToPurchase.Cost);
            return display;
        }
        public void GetCoinFromWallet(Customer customer,List<Coin> payment, string coinToGet)
        {
            for (int i = 0; i < customer.wallet.coins.Count; i++)
            {
                if (customer.wallet.coins[i].name == coinToGet)
                {
                    Coin coinToPayWith = customer.wallet.coins[i];
                    payment.Add(coinToPayWith);
                    customer.wallet.coins.Remove(coinToPayWith);
                    break;
                }
            }   
        }
        public List<Coin> GetPayment(Customer customer)
        {
            List<Coin> payment = new List<Coin>();

            Console.WriteLine("How many quarters to add?");

            int qCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < qCount; i++)
            {
                GetCoinFromWallet(customer, payment, "Quarter");
            }
            Console.WriteLine("How many dimes to add?");
            int dCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < dCount; i++)
            {
                GetCoinFromWallet(customer, payment, "Dime");
            }
            Console.WriteLine("How many nickels to add?");
            int nCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < nCount; i++)
            {
                GetCoinFromWallet(customer, payment, "Nickel");
            }
            Console.WriteLine("How many pennies to add?");
            int pCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pCount; i++)
            {
                GetCoinFromWallet(customer, payment, "Penny");
            }
            return payment;


           



            //Console.WriteLine($"Please deposit money in slot below");
            //Console.WriteLine("How many quarters");
            //double qCount = double.Parse(Console.ReadLine());
            //double qChange = (qCount * .25);
            //Console.WriteLine("How many dimes");
            //double dCount = double.Parse(Console.ReadLine());
            //double dChange = (dCount * .10);
            //Console.WriteLine("How many nickels");
            //double nCount = double.Parse(Console.ReadLine());
            //double nChange = (nCount * .05);
            //Console.WriteLine("How many pennies");
            //double pCount = double.Parse(Console.ReadLine());
            //double pChange = (pCount * .01);

            //double tChangeCount = (qChange + dChange + nChange + pChange);
        }
        public void VerifyPayment(List<Coin> payment, List<Coin> display,)
        {
            bool isPaymentCorrect = false;
            while (isPaymentCorrect)
            {
                if (payment==display)
                {
                    bool = true;

                }
            }
            {
                GetCoinFromWallet
            }
            
                
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
