using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapeList = new List<Shape>();
        Rectangle newRectangle = new Rectangle(5.0,6.0,"red");
        Square newSquare = new Square(6.0,"blue");
        Circle newCircle = new Circle(4.0,"yellow");
        shapeList.Add(newRectangle);
        shapeList.Add(newSquare);
        shapeList.Add(newCircle);


        foreach(Shape shape in shapeList ){
            Console.WriteLine($"{shape.getColor()} {String.Format("{0:0.##}",shape.GetArea())}");
           
        }
       


       
    }


}