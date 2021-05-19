using System;

namespace Classes
{
    public class car
    {
        // Member variables

        //color of the car
        public string color { get; set; }

        // Make of the car
        private string make { get; set; }

       //Year of the car
        public string year { get; set; }

        // Functions 
        // 1. constructors
        public car()
        {
            Console.WriteLine ("I am constructor");

           color = "Red";
            make = "Toyota";
            year = "2021";
        }
        // 2.Methods/Functions
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            car car_obj = new car();
        }
    }
}
