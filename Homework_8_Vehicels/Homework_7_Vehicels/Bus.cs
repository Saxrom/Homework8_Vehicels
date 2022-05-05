using System;
namespace Homework_7_Vehicels
{
    class Bus:Vehicels
    {
        public byte PassengerCount { get; set; }

        public Bus(string brand,string model,string color,string maxspeed,byte passengercount):base(brand,model,color,maxspeed)
        {
            PassengerCount = passengercount;
        }

        public override void Info()
        {
            if (Brand==null&&Model==null)
            {
                Console.WriteLine("Brand-siz ve ya model-siz vicel yaradila bilmez"); 
            }

            else
            {
                Console.WriteLine($"Brand:{Brand},Model:{Model},Color:{Color},MaxSpeed:{MaxSpeed},PassengerCount:{PassengerCount}");

            }



        }
    }
} 
