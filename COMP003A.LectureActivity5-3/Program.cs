using COMP003A.LectureActivity5_3;

//Author: Victor Flores
//Course:COMP-003A
//Faculty: Jonathan Cruz
//Purpose: Demonstrate abstract and interfaces oop
namespace COMP003A.LectureActivity5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a circle and rectangle
            Shape myCircle = new Circle(5);
            //create rectangle
            Shape myRectangle = new Rectangle(4, 6);

            //display info about circle
            myCircle.DisplayInfo();
            Console.WriteLine($"Area: {myCircle.CalculateArea()}");
            ((IDrawable)myCircle).Draw();

            //display info rectangle 
            myRectangle.DisplayInfo();
            Console.WriteLine($"Area; {myRectangle.CalculateArea()}");
            ((IDrawable)myRectangle).Draw();
        }
    }


    abstract class Shape
    {
        //auto implement property 
        public string Name { get; set; }

        ///<summary>
        ///Abstract method to calculate area 
        /// </summary>
        public abstract double CalculateArea();

        ///<summary>
        ///display shape name
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
    /// <summary>
    /// Represents a circle derived from shape
    /// </summary>
    class Circle : Shape , IDrawable 
    {
        //auto implemented property
        public double Radius { set; get; }

        ///<summary>
        ///constructor for circle 
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        ///<summary>
        ///Calculates the area of the circle
        /// </summary>
        public override double CalculateArea()
        {
            //return area of circle 
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Implement Draw() method for circle
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a cirlce.");
        }
    }

    class Rectangle : Shape, IDrawable
    {
        //auto implement properties 
        public double Width { set; get; }
        public double Height { set; get; }

        ///<summary>
        ///Constructor for rectangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle (double width, double height)
        {
            Name = "Rectangle";
            Width = width;
            Height = height;
        }

        ///<summary>
        ///calculates the area of rectangle
        /// </summary>
        public override double CalculateArea()
        {
           return Width * Height;
        }
        
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }

    }

    interface IDrawable
    {
        ///<summary>
        ///Draws the object
        /// </summary>
        void Draw();
    }
}


