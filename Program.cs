using System;
using static System.Console;

namespace MoneyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float TOTAL_MONEY = .92f;

            //Declaring value of coin
            float QUARTER = .25f;
            float DIME = .10f;
            float NICKEL = .05f;
            float PENNY = .01f;

            //Finding out how many quarters are in TOTAL_MONEY
            float quarterMath = TOTAL_MONEY / QUARTER;
            int numOfQuarters = (int)quarterMath;
           
            //Getting the remainer amount to figure out how much is left after the quarters
            float remainerAfterQuarters = TOTAL_MONEY % QUARTER;

            //Finding out how many dimes are in the remainerAfterQuarters
            float dimeMath = remainerAfterQuarters / DIME;
            int numOfDimes = (int)dimeMath;
            //Getting the remainer amount to figure out whats left after dime
            float remainerAfterDimes = remainerAfterQuarters % DIME;

            // Finding out how many nickles are in the remainerAfterDimes
            float nickelMath = remainerAfterDimes / NICKEL;
            int numOfNickels = (int)nickelMath;
            //Getting the remainer amount to figure out whats left after nickle
            float remainerAfterNickels = remainerAfterDimes % NICKEL;

            // Finding out how many pennies are in the remainerAfterNickles
            float pennyMath = remainerAfterNickels / PENNY;
            int numOfPennies = (int)pennyMath;

           
            Write("{0,20}\nChange Amount: {1:c}\n\nQuarters:{2,3}\nDimes:{3,6}\nNickels:{4,4}\nPennies:{5,4}\n","Changer App", TOTAL_MONEY, numOfQuarters, numOfDimes, numOfNickels, numOfPennies);
            ReadKey();
        }
    }
}
