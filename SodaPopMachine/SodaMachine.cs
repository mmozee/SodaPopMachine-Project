using SodaPopMachine;
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
        public void Transaction(Customer customer)
        {
            Can SodaThatWasSelected = SelectSodaForPurchase();
            DisplayCost(SodaThatWasSelected);
            List<Coin> payment = GetPayment(customer);
            VerifyPayment(SodaThatWasSelected, payment);
            GetMoneyForRefund(SodaThatWasSelected, payment, customer);




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
            Console.WriteLine("We couldn't find that soda, Select Another?");

            return SelectSodaForPurchase();
            

        }
        public void  DisplayCost(Can SodaToPurchase)
        {
          
            Console.WriteLine(SodaToPurchase.Cost);
            
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

        }
        public void VerifyPayment(Can can, List<Coin> payment)
        {
            bool isPaymentCorrect = false;
            while (isPaymentCorrect)
            {
                if (can.Cost <= GetTotalCoinListValue(payment))
                {
                    isPaymentCorrect = true;
                    Console.WriteLine("Your soda will dispense below");
                    Console.ReadLine();

                }
                else
                {
                    isPaymentCorrect = false;
                    Console.WriteLine("Please put on your glasses and try again Einstein");
                }
            }

        }
        public double GetTotalCoinListValue(List<Coin> tcoin)
        {
            double totalValue = 0;
            for (int i = 0; i < tcoin.Count; i++)
            {
                totalValue += tcoin[i].Value;
            }
            return totalValue;
        }
        public void GetMoneyForRefund(Can can, List<Coin> payment, Customer customer)
        {  
            double refund = ( GetTotalCoinListValue(payment) - can.Cost);

            if (can.Cost< GetTotalCoinListValue(payment))
            {
                Console.WriteLine($"You are due {refund}");
                Console.ReadLine();
            }
            for (int i = 0; i <customer.wallet.coins.Count; i++)
            {              
                payment.Add(customer.wallet.coins[i]);
                break;                   
            }    
        }     
        public void DispenseSoda(Can CanToDispense, Customer customer)
        {
            Console.WriteLine("Payment is correct, Good Job! Have a soda");
            Console.ReadLine();
            inventory.Remove(CanToDispense);
            customer.backPack.cans.Add(CanToDispense);
        }
       
    }
    
            
}
