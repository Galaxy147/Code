using System;

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;
        public void AcceptDetails()
        {
            length = 3.5;
            width = 4;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void OutputVars()
        {
            Console.WriteLine("LENGTH = {0}", length);
            Console.WriteLine("WIDTH = {0}", width);
            Console.Write("AREA = {0}", GetArea());
        }
    
    }
    class OutputRectangle
    {
        static void Main()
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.OutputVars();
            Console.ReadLine();
        }
    }
}