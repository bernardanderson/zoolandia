using System;

namespace Zoolandia
{
    class Bos : Animal
    {
        public int legs = 4;

        public string genus = "Bos";

        public virtual string hornNumber() {
            return "Hornless";
        }
    }
}