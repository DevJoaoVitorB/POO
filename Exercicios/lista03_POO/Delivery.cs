class Delivery
{
    private double distance, weight;

    public Delivery(){}

    public Delivery(double d, double w){
        if(d > 0) distance = d;
        if(w > 0) weight = w;
    }

    public void SetDistance(double d){
        if(d > 0) distance = d;
    }
    public void SetWeight(double w){
        if(w > 0) weight = w;
    }

    public double GetDistance(){
        return distance;
    }
    public double GetWeight(){
        return weight;
    }
    
    public double CalcDelivery(){
        return 0.01 * (weight / distance);
    }
    public override string ToString(){
        return $"Distância da Viagem: {distance:n0}km, Peso da Carga: {weight:f2}kg";
    }
}