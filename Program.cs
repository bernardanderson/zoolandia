using System;
using Zoolandia.Classes;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            AilurusFulgens ailurusFulgens = new AilurusFulgens();
            ailurusFulgens.height = "1ft";
            ailurusFulgens.color = "red";
            ailurusFulgens.hairStyle = "bushy";

            Console.WriteLine($"You have a {ailurusFulgens.color} ailurus fulgens named {ailurusFulgens.name} who is {ailurusFulgens.height} tall. It's hair is {ailurusFulgens.hairStyle}.");
            ailurusFulgens.talk();
            Console.WriteLine("***\n");

            GrizzlyBear grizzlyBear = new GrizzlyBear();
            grizzlyBear.height = "9ft";
            grizzlyBear.color = "brown";
            grizzlyBear.age = 16;

            Console.WriteLine($"You have a {grizzlyBear.age} year old, {grizzlyBear.color} grizzly bear named {grizzlyBear.name} who is {grizzlyBear.height} tall.");
            grizzlyBear.talk();
            Console.WriteLine("***\n");

            Panda panda = new Panda();
            panda.height = "5ft";
            panda.color = "black and white";
            panda.BambooType = "green and tasty";        

            Console.WriteLine($"You have a {panda.color} panda bear named {panda.name} who is {panda.height} tall. It likes to eat {panda.BambooType} bamboo." );
            panda.talk();
            Console.WriteLine("***\n");

            Manatee manatee = new Manatee();
            manatee.height = "4ft";
            manatee.color = "red";
            manatee.size = "600lbs";        

            Console.WriteLine($"You have a {manatee.color} manatee named {manatee.name} who is {manatee.height} tall. It weighs {manatee.size}.");
            manatee.talk();
            Console.WriteLine("***\n");

            GrizzlyBear overloadedGrizzly1 = new GrizzlyBear("Fred");
            Console.WriteLine($"This overloaded grizzly bear is named {overloadedGrizzly1.name}");
            Console.WriteLine("***\n");

            GrizzlyBear overloadedGrizzly2 = new GrizzlyBear(5);
            Console.WriteLine($"This overloaded grizzly bear is {overloadedGrizzly2.age} years old");
            Console.WriteLine("***\n");

            GrizzlyBear overloadedGrizzly3 = new GrizzlyBear("Jubb Jubb", 23);
            Console.WriteLine($"This overloaded grizzly bear is named {overloadedGrizzly3.name} and is {overloadedGrizzly3.age} years old");
            Console.WriteLine("***\n");

        }
    }
}
