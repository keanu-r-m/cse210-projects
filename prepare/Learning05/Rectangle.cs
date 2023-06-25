public class Rectangle : Shape {
    private double _length;
    private double _height;
    public Rectangle(string color, double length, double height) {
        SetColor(color);
        _length = length;
        _height = height;
    }
    public override double GetArea() {
        return _length * _height;
    }
}