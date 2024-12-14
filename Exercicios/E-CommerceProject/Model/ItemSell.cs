class ItemSell
{
    public int id {get; set;}
    public int qtd {get; set;}
    public double price {get; set;}
    public int idSale {get; set;}
    public int idProduct {get; set;}

    public ItemSell(int id, int qtd, double price){
        this.id = id;
        this.qtd = qtd;
        this.price = price;
    }

    public override string ToString(){
        return $"Quantidade: {qtd} \nPreço a Pagar: {price} \n";
    }

}