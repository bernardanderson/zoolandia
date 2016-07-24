using System;

namespace Zoolandia
{
    public class Animal
    {

        public string name { get; set; }

        public string color { get; set; }

        public string height { get; set; }

        public int age { get; set; }

        public virtual void walk ()
        {
            Console.WriteLine("This animal is now walking");
        }

        public virtual void talk ()
        {
            Console.WriteLine("This animal is now talking");
        }

        public virtual void sleep ()
        {
            Console.WriteLine("This animal is now sleeping");
        }
    }

}