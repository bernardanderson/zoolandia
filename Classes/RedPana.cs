using System;

namespace Zoolandia.Classes
{
    class AilurusFulgens : Animal
    {

        public AilurusFulgens() {
            this.name = "Franco";
        }
        public string hairStyle { get; set; }

        public override void talk ()
        {
            base.talk();
            Console.WriteLine("This red pana says whoop whoop!");
        }
    }
}