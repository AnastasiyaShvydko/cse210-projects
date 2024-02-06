public class Circle:Shape{
    private double _radius;
   


public Circle(double side , string color){
_radius =side;
setColor(color);



}

  

public override double GetArea(){
    double Area =  Math.PI * Math.Pow(_radius, 2);
    return Area;
}


}