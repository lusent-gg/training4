
using factory;
using System.Security.Cryptography.X509Certificates;

char x = 'y';

calculator n1 = new prime(); 

uint number ;

do
{

    char select = keyboard.getkey();


    if (select == 'z')
    {
        Console.WriteLine("\nExiting the application...");
        Environment.Exit(0);
    }

    if (select == 'c')
    {
        decisiontree.tree();
    }

    if (select == 'a'|| select == 'b')
    {

        number = keyboard.getnumber();
        n1 = factor.factory(number, select, n1);
        Console.WriteLine(n1.IsTrue(number));
    }

   



    

    
    
    x = keyboard.getyon();

} while (x != 'n');

Console.WriteLine("\nExiting the application...");










