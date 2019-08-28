using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

    //



            string[] planets = new string[9];


            planets[0] = "Mercury;
            planets[1] = "Venus";
            planets[2] = "Earth";
            planets[3] = "Mars";
            planets[4] = "Jupiter";
            planets[5] = "Saturn";
            planets[6] = "Uranus";
            planets[7] = "Neptune";
            planets[8] = "Pluto";


            int count = 0;
            while(count < planets.Length)
            {
                Console.WriteLine(planets[count]);

                count++;
            }

            Console.WriteLine("Hello World!");





        }
    }


}
