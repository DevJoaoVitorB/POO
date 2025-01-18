static class View
{
    public static object Verification(double b, double h)
    {
        if(b == h){
            Square x = new Square(b);
            return x;
        } else {
            Rectangle y = new Rectangle(b, h);
            return y;
        }
    }
}