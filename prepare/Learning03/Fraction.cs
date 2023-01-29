public class Fraction{
    private int _top;
    private int _bottom;
    
    // constructors 
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    // getters and setters
    public string GetTop(){
        return _top.ToString();
    }
    public string GetBottom(){
        return _bottom.ToString();
    }
    public void SetTop(int top){
        _top = top;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }
    // methods
    public string GetFractionString(){
        string str = $"{_top}/{_bottom}";
        return str;
    }
    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }

}