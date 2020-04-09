using System;

namespace ConsoleApp1
{   
    public class ATM
    {
        public void ShowAccountStats()
        {

        }
        public void Withdraw()
        {

        }

        public void Cashin()
        {

        }
    }





    /*
      0 - Basic
      1 - Premim
      2 - Platinum
    */



    class Program
    {
        static void Main(string[] args)
        {
            var card1 = new BasicCard();
            card1.CardInit(1000);
            Console.WriteLine("ID: " + card1.id + "\nbalance: " + card1.balance);
            Console.ReadLine();
        }
    }
}
