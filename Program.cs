using System;

namespace ConsoleApp1
{   
    public class ATM
    {
        public void showAccountStats()
        {

        }
        public void withdraw()
        {

        }

        public void cashin()
        {

        }
    }

    public class Shop
    {
        public void payCash()
        {

        }
        public void payBonuses()
        {

        }
    }

    public class Airline
    {
        public void payCash()
        {

        }
        public void payBonuses()
        {

        }
        public void payMiles()
        {

        }
    }

    /*
      0 - Basic
      1 - Premim
      2 - Platinum
    */
    public class Card   
    {   
        public int id;
        public int type;
        public int comission;
        public int[] balance;
    }

    public class BasicCard : Card
    {
        
        public void cardInit(int b)
        {
            Random rnd = new Random(); 

            id = rnd.Next(1000000, 999999999);
            type = 0;
            balance[0] = b;
        }
        
    }

    public class PremiumCard : Card
    {
        /*
         0 - cash
         1 - bonuses
         */
        public void cardInit(int cash, int bonus)
        {
            balance[0] = cash;
            balance[1] = bonus;
        }
       

    }

    public class PlatinumCard : Card
    {
        /*
         0 - cash
         1 - bonuses
         2 - miles
         */
        public void cardInit(int cash, int bonus, int miles)
        {
            balance[0] = cash;
            balance[1] = bonus;
            balance[2] = miles;
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            var card1 = new BasicCard();
            card1.cardInit(1000);
            Console.WriteLine("ID: " + card1.id + "\nbalance: " + card1.balance);
            Console.ReadLine();
        }
    }
}
