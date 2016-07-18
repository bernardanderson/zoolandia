using System;

namespace Zoolandia.Classes
{
    public class Animal
    {
        public string name { get; set; }

        public string color { get; set; }

        public string height { get; set; }

        public string weight { get; set; }

        public static void walk ()
        {
            Console.WriteLine("Animal is now walking");
        }

        public static void talk ()
        {
            Console.WriteLine("Animal is now talking");
        }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    }

}