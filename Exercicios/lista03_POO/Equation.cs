class Equation
{
    private int a, b, c;
    private double delta, x1, x2;
    public Equation(){}

    public Equation(int a, int b, int c){
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void SetA(int a){
        this.a = a;
    }
    public void SetB(int b){
        this.b = b;
    }
    public void SetC(int c){
        this.c = c;
    }

    public int GetA(){
        return a;
    }
    public int GetB(){
        return b;
    }
    public int GetC(){
        return c;
    }

    public double Delta(){
        delta = Math.Pow(b, 2) - (4 * a * c); 
        return delta;
    }
    
    public double Root1(){
        x1 = (-b + Math.Sqrt(delta))/2 * a;
        return x1;
    }

    public double Root2(){
        x2 = (-b - Math.Sqrt(delta))/2 * a;
        return x2;
    }

    public bool RealRoot(){
        if (((x1*10 % 10) != 0) || ((x2*10 % 10) != 0)){
            return true;
        }else{
            return false;
        }
    }

    public override string ToString(){
        return $"a = {a}, b = {b}, c = {c}";
    }
}