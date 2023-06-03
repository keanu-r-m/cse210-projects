public class Fraction 
{
    private int _top;
    private int _bottom;
  
    public Fraction() {
      _top = 1;
      _bottom = 1;
    }
    public Fraction(int nominator) {
      _top = nominator;
      _bottom = 1;
    }
    public Fraction(int nominator, int denominator) {
      _top = nominator;
      _bottom = denominator;
    }
    public int GetTop() {
      return _top;
    }
    public void SetTop(int top) {
      _top = top;
    }
    public int GetBottom() {
      return _bottom;
    }
    public void SetBottom(int bottom) {
      _bottom = bottom;
    }
    public string GetFractionString() {
      return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue() {
      return Convert.ToDouble(_top) / _bottom;
    }
}