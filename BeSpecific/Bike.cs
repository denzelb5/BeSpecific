using System;
using System.Collections.Generic;
using System.Text;

namespace BeSpecific
{
    class Bike : HobbyBase
    {
        public bool HasPedals { get; set; }
        public string Color;

        public Bike(string color)
        {
            Color = color;

        }
        public void Ride()
        {
            Console.WriteLine("Does your bike have pedals? Type y / n");
            var pedalAnswer = Console.ReadLine();
            if (pedalAnswer == "y")
            {
                HasPedals = true;
            }
            else
            {
                HasPedals = false;
            }

            if (HasPedals)
            {
                Console.WriteLine("Ride On!");
            }
            else
            {
                Console.WriteLine("We can sell you a bike for 19,999.95!");
            }
        }
        public void BikeColor()
        {
            Console.WriteLine("Do you own a bike? y / n");
            var answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("What color is your bike?");
                var response = Console.ReadLine();
                Console.WriteLine($"You have a {response} bike ");
            }
            else
            {
                Console.WriteLine("We can sell you a bike for 19,999.95!");
            }
        }
    }
}
