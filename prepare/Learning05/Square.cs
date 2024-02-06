public class Square:Shape{
    private double _side;
   


public Square(double side , string color){
_side =side;
setColor(color);



}

  

public override double  GetArea(){
    double Area = _side * _side;
    return Area;
}


}