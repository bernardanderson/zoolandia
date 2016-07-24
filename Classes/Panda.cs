using System;

namespace Zoolandia
{
    class Panda : Animal
    {
        public Panda() {
            this.name = "Ling Ling";
        }
        
        public string BambooType { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This panda says whobba whobba!");
        }
    }
}