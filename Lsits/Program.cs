using System;
using System.Collections.Generic;

namespace Lsits
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[5];
            List<string> planets = new List<string>(5);

            planets.Add("Mercury");
            planets.Add("Venus");
            planets.Add("Earth");
            planets.Add("Mars");
            planets.Add("Jupiter");
            planets.Add("Saturn");
            planets.Add("Uranus");
            planets.Add("Neptune");
            planets.Add("Pluto");

            foreach (var item in planets)
            {
                Console.WriteLine(item);

            }


        }
    }
}
