
namespace factory;

class keyboard
{

    public static char getkey()
    {
        char b;

        Console.Clear();
        Console.WriteLine("a_prime num");
        Console.WriteLine("b_mirror");
        Console.WriteLine("c_decision tree");
        Console.WriteLine("z_close app");

        b = Console.ReadKey().KeyChar;
        Console.Clear();
        return b;
       


    }


    public static uint getnumber()
    {
        
        
        Console.WriteLine("\nenter a number");
        
        char x;
        string y ="";
        uint c = 0;

        do
        {
            x = Console.ReadKey().KeyChar;
            y = y + x;
        } while (char.IsDigit(x));
        
        c = Convert.ToUInt32(y);
        
        return c;
    }



    public static char getyon()
    {


        Console.WriteLine("\ndo you want to continue? y/n");

        char x;
        
        

        do
        {
            x = Console.ReadKey().KeyChar;
            break;
            
        } while (!char.IsDigit(x) );
        
        

        return x;
    }

}
