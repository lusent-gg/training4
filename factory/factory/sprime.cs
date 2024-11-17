

namespace factory;

class sprime: calculator
{

    public override bool IsTrue(uint number)
    {
        

        bool check = true;
        int condition = Convert.ToInt32(Math.Sqrt(number));
        for (int j = 2; (check && j <= condition); j++)
            if (number % j == 0)
                check = false;

 
        return check;
    }




}

