namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A list with Circle directly created in it which has the values for radius and name
            List<Circle> circles = new List<Circle>
            {
                new Circle(5, "Circle 1"),
                new Circle(6, "Circle 2")
            };

            // Loop through each circle in the list
            foreach (var c in circles)
            {
                // Print the string representation of the current circle
                Console.WriteLine(c.ToString());
            }
        }

        //Class for Circle
        public class Circle
        {
            // Property to hold the radius of the circle
            public double _radius { get; set; }
            public string _name { get; set; }

            // Constructor for the circle's radius
            public Circle(double radius, string name)
            {
                _radius = radius;
                _name = name;
            }

            // Method to calculate the area of the circle (pi * radius²)
            public double GetArea()
            {
                return Math.PI * Math.Pow(_radius, 2);
            }

            // Method to calculate the circumference of the circle (2 * pi * radius)
            public double GetCircumference()
            {
                return 2 * Math.PI * _radius;
            }

            // Method to calculate the volume of a sphere with the same radius (4/3 * pi * radius³)
            public double GetVolume()
            {
                return (4 / 3) * Math.PI * Math.Pow(_radius, 3);
            }

            // Override ToString method to display the circle's name, radius, area, circumference and volume
            public override string ToString()
            {
                return $"{_name}, Radius: {_radius}, Area: {GetArea()}, Circumference: {GetCircumference()}, Volume {GetVolume()}";
            }
        }
    }
}
