using System;

namespace Zoolandia.Classes
{
    class GrizzlyBear : Animal
    {
        public GrizzlyBear() {
            this.name = "Ben";
        }

        public GrizzlyBear(string sentName)
        {
            this.name = sentName;
        }

        public GrizzlyBear(int sentAge)
        {
            this.age = sentAge;
        }

        public GrizzlyBear(string sentName, int sentAge)
        {
            this.name = sentName;
            this.age = sentAge;
        }

        public int age { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This grizzly says gerrr... gerrr!");
        }
    }
}