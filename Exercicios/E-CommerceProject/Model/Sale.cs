class Sale
{
    public int id {get; set;}
    public DateTime day {get; set;}
    public bool cart {get; set;}
    public double total {get; set;}
    public int idClient {get; set;}

    public Sale(int id){
        this.id = id;
    }

    public override string ToString(){
        return $"COMPRA {id}: \n\tDia da Compra: {day} \n\tTotal a Pagar: {total} \n\t";
    }
}