static class View
{
    public static Sphere GetSphere(double radius)
    {
        Sphere x = new Sphere(radius);
        return x;
    }

    public static Cube GetCube(double side)
    {
        Cube y = new Cube(side);
        return y;
    }
}