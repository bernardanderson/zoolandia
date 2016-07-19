using System;

namespace Zoolandia.Classes
{
    class Manatee : Animal
    {
        public string size { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This manatee says blub blub!");
        }
    }
}