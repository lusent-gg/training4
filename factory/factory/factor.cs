

namespace factory;

static class factor 
{
    public static calculator factory(uint number, char select , calculator n1)
    {

        //calculator n1;
        
        if (number <= 1000 && select == 'a')
        {
            Console.WriteLine(number);
            n1 = new prime();
        }
        if (number > 1000 && select == 'a')
        {
            Console.WriteLine("asdasd");
            n1 = new sprime();
        }
        if (select == 'b')
        {
            uint b ;
            Console.Clear();
            Console.WriteLine("method 1 or 2");
            b = keyboard.getnumber();
            
            if (b == 1)
            {
                n1 = new palindrom();
            }

            if (b == 2)
            {
                n1 = new palindrom2();
            }
        }
        
        

       


        return n1;
    }




}
