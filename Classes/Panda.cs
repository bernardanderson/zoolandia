using System;

namespace Zoolandia.Classes
{
    class Panda : Animal
    {
        public string BambooType { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This panda says whobba whobba!");
        }
    }
}