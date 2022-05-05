using System;
namespace Homework_7_Vehicels
{
    abstract class Vehicels
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        protected string Color { get; set; }
        protected internal string MaxSpeed { get; set; }

        public Vehicels()
        {
            Console.WriteLine("Car created");
            Console.WriteLine();
        }


        public Vehicels(string brand,string model):this()
        {
            Brand = brand;
            Model = model;
        }

        public Vehicels(string brand,string model,string color,string maxspeed):this(brand,model)
        {
            Color = color;
            MaxSpeed = maxspeed;
        }


        public abstract void Info();

    }
}
