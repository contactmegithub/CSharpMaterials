using System;

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;
        public Rectangle()
        {

        }
        public Rectangle(double len, double wid)
        {
            length = len;
            width = wid;
        }

        ~Rectangle()
        {

        }
        // member variables


        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.GetArea();


            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}