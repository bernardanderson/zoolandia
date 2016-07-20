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

            GrizzlyBear grizzlyBear = new GrizzlyBear();
            grizzlyBear.height = "9ft";
            grizzlyBear.color = "brown";
            grizzlyBear.aggresiveness = "very aggressive";

            Panda panda = new Panda();
            panda.height = "5ft";
            panda.color = "black and white";
            panda.BambooType = "green and tasty";        

            Manatee manatee = new Manatee();
            manatee.height = "4ft";
            manatee.color = "red";
            manatee.size = "600lbs";        

            Console.WriteLine($"You have a {ailurusFulgens.color} ailurus fulgens named {ailurusFulgens.name} who is {ailurusFulgens.height} tall. It's hair is {ailurusFulgens.hairStyle}.");
            ailurusFulgens.talk();
            Console.WriteLine("***");

            Console.WriteLine($"You have a {grizzlyBear.aggresiveness}, {grizzlyBear.color} grizzly bear named {grizzlyBear.name} who is {grizzlyBear.height} tall.");
            grizzlyBear.talk();
            Console.WriteLine("***");

            Console.WriteLine($"You have a {manatee.color} manatee named {manatee.name} who is {manatee.height} tall. It weighs {manatee.size}.");
            manatee.talk();
            Console.WriteLine("***");

            Console.WriteLine($"You have a {panda.color} panda bear named {panda.name} who is {panda.height} tall. It likes to eat {panda.BambooType} bamboo." );
            panda.talk();
            Console.WriteLine("***");
        }
    }
}
