static class View
{
    public static object DeliveryCreate(double d, double w, decimal i)
    {
        if(i == 0){Delivery x = new Delivery(d, w); return x;} else {ExpressDelivery y = new ExpressDelivery(d, w, i); return y;}
    }
}