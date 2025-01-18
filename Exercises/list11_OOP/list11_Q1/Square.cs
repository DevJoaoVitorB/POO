class Rectangle
{
    private double b;
    private double h;

    public Rectangle(double b, double h)
    {
        if(b == 0) {throw new ArgumentException("O Valor da Base não pode ser Vazio!");} else {this.b = b;}
        if(h == 0) {throw new ArgumentException("O Valor da Altura não pode ser Vazio!");} else {this.h = h;}
    }

    public double GetBase()
    {
        return b;
    }

    public double GetHeight()
    {
        return h;
    }

    public virtual double CalcArea()
    {
        return (b * h) / 2;
    }

    public virtual double CalcDiagonal()
    {
        return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
    }

    public override string ToString()
    {
        return $"\nRETÂNGULO: \n\tBase: {b:f2} \n\tAltura: {h:f2} \n\tÁrea: {CalcArea():f2} \n\tDiagonal: {CalcDiagonal():f2}";
    }
}

class Square : Rectangle
{
    public Square(double s) :
    base (s, s)
    { 
    }

    public override double CalcArea()
    {
        return GetBase() * GetHeight();
    }

    public override double CalcDiagonal()
    {
        return GetBase() * Math.Sqrt(2);
    }

    public override string ToString()
    {
        return $"\nQUADRADO: \n\tLados: {GetBase():f2} \n\tÁrea: {CalcArea():f2} \n\tDiagonal: {CalcDiagonal():f2}";
    }
}