using System.Drawing;

public class Rectangle:Shape{
    private double _width;
    private double _lenght;


public Rectangle(double width, double lenght , string color){
_lenght = lenght;
_width = width;
setColor(color);



}

  

public override double GetArea(){
    double Area = _lenght * _width;
    return Area;
}


}