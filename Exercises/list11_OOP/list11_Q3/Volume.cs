abstract class FigureVolume{
    public abstract double GetVolume();
}

class Sphere : FigureVolume
{
    private double radius;

    public Sphere(double r)
    {
        if(r <= 0) {throw new ArgumentException("O Raio da Esfera deve ter Valor maior que 0(Zero)!");} else {radius = r;}
    }

    public override double GetVolume()
    {
        return (double)4/3 * Math.PI * Math.Pow(radius, 3);
    }

    public override string ToString()
    {
        return $"\nESFERA: \t\nRaio: {radius:f2} \t\nVolume: {GetVolume():f2}";
    }
}

class Cube : FigureVolume
{
    private double side;

    public Cube(double s)
    {
        if(s <= 0) {throw new ArgumentException("Os Lados do Cubo devem ter Valor maior que 0(Zero)!");} else {side = s;}
    }

    public override double GetVolume()
    {
        return Math.Pow(side, 3);
    }

    public override string ToString()
    {
        return $"\nCUBO: \t\nLado: {side:f2} \t\nVolume: {GetVolume():f2}";
    }
    
}