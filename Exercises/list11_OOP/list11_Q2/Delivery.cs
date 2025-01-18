class Delivery
{
    protected double d;
    protected double w;

    public Delivery(double distance, double weight)
    {
        if(distance <= 0) {throw new ArgumentException("Valor Inválido! Distância não pode ser 0(Zero) ou Negativa!");} else {d = distance;}
        if(weight <= 0) {throw new ArgumentException("Valor Inválido! Peso não pode ser 0(Zero) ou Negativo!");} else {w = weight;}
    }

    public virtual double DeliveryPrice()
    {
        return 0.01 * w * d;
    }

    public override string ToString()
    {
        return $"\nFRETE BÁSICO: \t\nDistância: {d:f2}km \t\nPeso: {w:f2}kg \t\nValor de Pagamento: R${DeliveryPrice():f2}";
    }
}

class ExpressDelivery : Delivery
{
    private decimal i;

    public ExpressDelivery(double distance, double weight, decimal insurance) :
    base(distance, weight)
    {
        if(insurance <= 1) {throw new ArgumentException("Valor Inválido - O Valor Informado do Seguro deve ser maior que R$1");} else {i = insurance;}
    }

    public override double DeliveryPrice()
    {
        return 0.01 * w * d * 2 + (0.01 * (double)i);
    }

    public override string ToString()
    {
        return $"\nFRETE EXPRESSO: \t\nDistância: {d:f2}km \t\nPeso: {w:f2}kg \t\nSeguro: R${i:f2} \t\nValor de Pagamento: R${DeliveryPrice():f2}";
    }
}