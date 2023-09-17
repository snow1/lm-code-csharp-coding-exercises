using System;
namespace Exercises
{
    public class Exercise003
    {
        // Replace the exception statement below with your code!
        public string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        // Replace the exception statement below with your code!
        public int IceCreamCode(string iceCreamFlavour)
        {
            if (iceCreamFlavour == "Raspberry Ripple")
            {
                return 1;
            }
            else if(iceCreamFlavour == "Vanilla")
            {
                return 2;
            }
            else if (iceCreamFlavour == "Mint Chocolate Chip")
            {
                return 3;
            }
            else if (iceCreamFlavour == "Chocolate")
            {
                return 4;
            }
            else if (iceCreamFlavour == "Mango Sorbet")
            {
                return 5;
            }
            else
            {
                return 0;
            }

        }
    }
}
