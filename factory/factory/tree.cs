

namespace factory;

internal class decisiontree 
{

    public static void tree()
    {
        int x = 0;
        bool loop = true;



        /* 
         * 
         * عدد ها از چپ به راست بسته به انتخاب در سوال ها در عدد گزاری شده
         * مثال : اگه اول 1 بعد 2 بعد 1 را نتخاب کند در کیس 121 است 
         * 
         */

        do
        {

            switch (x)
            {

                case 0:
                    Console.Write("do you like girls? 1-yes 2-no :");
                    x = int.Parse(Console.ReadLine());
                    break;



                case 1:
                    Console.Write("do you have gf? 1-yes 2-no :");
                    x = 10 + int.Parse(Console.ReadLine());
                    break;

                case 2:

                    Console.Write("sooo do you like bois ??? 1-yes 2-no :");
                    x = 20 + int.Parse(Console.ReadLine());
                    break;


                case 11:

                    Console.Write("is she prity? 1-yes 2-no :");
                    x = 110 + int.Parse(Console.ReadLine());
                    break;

                case 12:

                    Console.Write("do you want one ? 1-yes 2-no :");
                    x = 120 + int.Parse(Console.ReadLine());
                    break;

                case 21:

                    Console.Write("are you gay? 1-yes 2-no :");
                    x = 210 + int.Parse(Console.ReadLine());
                    break;

                case 22:
                    Console.Write("are you sigma ? 1 - yes 2 - no :");
                    x = 220 + int.Parse(Console.ReadLine());
                    break;


                case 121:
                    Console.Write("do you go to party often ? 1-yes 2-no :");
                    x = 1210 + int.Parse(Console.ReadLine());
                    break;


                case 122:
                    Console.Write("why are you here then you have to be on gay part of app");
                    x = 69;
                    break;


                case 111:
                    Console.Write("good for you have fun with her ;]");
                    x = 69;
                    break;

                case 112:
                    Console.Write("does she have nice personality ?? 1-yes 2-no :");
                    x = 1120 + int.Parse(Console.ReadLine());
                    break;


                case 211:

                    Console.Write("get out of my app");
                    x = 69;
                    break;


                case 212:

                    Console.Write("are you lying to me ?? 1-yes 2-no :");
                    x = 2120 + int.Parse(Console.ReadLine());
                    break;

                case 221:
                    Console.Write("do you know what sigma mean ? 1-yes 2-no :");
                    x = 2220 + int.Parse(Console.ReadLine());
                    break;

                case 222:
                    Console.Write("so you are ligma(to scared to continue this part)");
                    x = 69;
                    break;



                case 1121:
                    Console.Write("so you are the type of guy that chose personality over beauty");
                    x = 69;
                    break;

                case 1122:
                    Console.Write("bro broke up with her lamo :/");
                    x = 69;
                    break;

                case 1211:
                    Console.Write("try to fine gf there your wellcome");
                    x = 69;
                    break;

                case 1212:
                    Console.Write("try finding some one in tinder");
                    x = 69;
                    break;

                case 2121:
                    Console.Write("sooo you are gay hmmmm... get out of my app");
                    x = 69;
                    break;

                case 2122:
                    Console.Write("liarrrrr .... get out of my app lamo :/");
                    x = 69;
                    break;

                case 2221:
                    Console.Write("so you are a true sigma");
                    x = 69;
                    break;

                case 2222:
                    Console.Write("so you are gay lamo (why im writing this code idk help plsssss)");
                    x = 69;
                    break;


                case 69:
                    loop = false;
                    break;









            }





        } while (loop);


    }



}
