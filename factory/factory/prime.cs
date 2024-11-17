namespace factory;


using System.Security.Cryptography.X509Certificates;

class prime : calculator
{

    public override bool IsTrue(uint number)
    {
        bool check;
        check = true;
        

        for (int j = 2; (check && j < number); j++)
            if (number % j == 0)
                check = false;

        if (check)
            
            check = true;



        return check;
    }


}
    
    
