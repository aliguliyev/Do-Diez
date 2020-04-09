
/*
  0 - Basic
  1 - Premim
  2 - Platinum
*/

using System;
namespace ConsoleApp1

{
    public class Card
    {
        public int id;
        public int type;
        public int comission;
        public int[] balance;
    }

    public class BasicCard : Card
    {

        public void CardInit(int b)
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
        public void CardInit(int cash, int bonus)
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
        public void CardInit(int cash, int bonus, int miles)
        {
            balance[0] = cash;
            balance[1] = bonus;
            balance[2] = miles;
        }

    }
}