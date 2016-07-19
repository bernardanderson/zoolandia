using System;

namespace Zoolandia.Classes
{
    public class Animal
    {



        public string name { get; set; }

        public string color { get; set; }

        public string height { get; set; }

        public void walk ()
        {
            Console.WriteLine("This animal is now walking");
        }

        public virtual void talk ()
        {
            Console.WriteLine("This animal is now talking");
        }

        public void sleep ()
        {
            Console.WriteLine("This animal is now sleeping");
        }
    }

}