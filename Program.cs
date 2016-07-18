using System;
using Zoolandia.Classes;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Animal generic = new Animal();
            generic.name = "Fred";

            Console.WriteLine("Animal is " + generic.name);

        }
    }
}
