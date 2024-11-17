

namespace factory;

internal class palindrom2 : calculator
{
    public override bool IsTrue(uint number)
    {


        uint divisor = 1;
        while (number / divisor >= 10)
        {
            divisor *= 10;
        }

        
        while (number > 0)
        {
            uint leading = number / divisor; 
            uint trailing = number % 10;    

            if (leading != trailing)
            {
                return false; 
            }

           
            number = (number % divisor) / 10;

            
            divisor /= 100;
        }

        return true;
    }







}




