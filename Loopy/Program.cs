using System;

namespace Loopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int y = 0;
            while(y < 10)
            {
                int x = 0;
                while (x < 20)
                {
                    Console.Write("x");
                    x++;
                }
                Console.WriteLine("");
                y++;
            }



            

        }
    }
}
