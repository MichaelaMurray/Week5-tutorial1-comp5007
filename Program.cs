using System;

namespace week5_tutorial1_comp5007
{
    public class Shape
    {
        public void Draw() 
        {}
    
        public class Rectangle : Shape
        {

        }

        public class Circle : Shape
        {

        }

        public class Triangle : Shape
        {

        }    
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Shape(Triangle));
            shapes.Add(new Shape(Circle));
            shapes.Add(new Shape(Rectangle));

            foreach (Shape shapes in shapes)
            {
              Console.Draw()  
            }
        }
    }
}
