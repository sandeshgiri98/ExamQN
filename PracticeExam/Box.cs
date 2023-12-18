//Create a class box with instance variable length, breadth and height and properties to set and get
//value of instance variable. Now calculate a volume of box and display value of instance variable.

using System;


namespace AdvanceDotNet
{
    using System;

    class Box
    {
        private double length;
        private double breadth;
        private double height;

        // Properties to set and get the values of instance variables
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Method to calculate the volume of the box
        public double CalculateVolume()
        {
            return length * breadth * height;
        }

        // Method to display the values of instance variables
        public void DisplayBoxDetails()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Breadth: {breadth}");
            Console.WriteLine($"Height: {height}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the Box class
            Box myBox = new Box();

            // Set the values of instance variables using properties
            myBox.Length = 5.0;
            myBox.Breadth = 3.0;
            myBox.Height = 2.0;

            // Display the values of instance variables
            Console.WriteLine("Box Details:");
            myBox.DisplayBoxDetails();

            // Calculate and display the volume of the box
            double volume = myBox.CalculateVolume();
            Console.WriteLine($"Volume of the Box: {volume}");
        }
    }


}
