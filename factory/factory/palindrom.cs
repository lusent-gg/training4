

namespace factory;
class palindrom : calculator
{

    public override bool IsTrue(uint number)
    {


        uint original = number, reversed = 0;
        while (number > 0)
        {
                uint digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
        }
        
        
        return original == reversed;
        










        
    }
}

