class Rectangle
{
    private double b, h;

    public Rectangle(){}

    public Rectangle(double b, double h){
        if (b > 0) this.b = b;
        if (h > 0) this.h = h;
    }

    public void SetB(double b){
        if(b > 0) this.b = b;
    }
    public void SetH(double h){
        if(h > 0) this.h = h;
    }

    public double GetB(){
        return b;
    }
    public double GetH(){
        return h;
    }

    public double CalcDiagonal(){
        return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
    }

    public override string ToString(){
        return $"Base = {b:f2}, Altura = {h:f2}";
    }
}