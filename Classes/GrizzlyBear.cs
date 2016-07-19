using System;

namespace Zoolandia.Classes
{
    class GrizzlyBear : Animal
    {
        public GrizzlyBear() {
            this.name = "Ben";
        }
        public string aggresiveness { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This grizzly says gerrr... gerrr!");
        }
    }
}