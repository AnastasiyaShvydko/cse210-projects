public class BMRcalculator{
    double _bodyMass ;
    double _height ;

    int _age;

    string _gender;

public BMRcalculator(double bodyMass, double height, int age, string gender ){

    _bodyMass = bodyMass;
    _height = height;
    _age = age;
    _gender = gender;
}

public double calculateBMR(){
    if(_gender == "female"){
        double bmr = (10*_bodyMass) + (6.25*_height) - 5*_age - 161;
        return bmr;
    }
    else{
        double bmr = (10*_bodyMass) + (6.25*_height) - 5*_age + 5;
        return bmr;
    }
}

}