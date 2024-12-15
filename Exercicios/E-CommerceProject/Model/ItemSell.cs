using System.Text.Json;

static class ItemSellList
{
    private static List<ItemSell> ISList = new List<ItemSell>(); // Lista de Venda de Item

    public static void Insert(ItemSell x){
        // Abrir Lista de Venda de Item
        Open();
        // Obter o Maior ID da Lista de Venda de Item e Somar +1
        int id = 0;
        foreach (ItemSell i in ISList) if (i.id > id) id = i.id;
        x.id = id + 1;
        // Adicionar uma Venda de Item e Salvar
        ISList.Add(x);
        Close();
    }

    public static void Del(ItemSell x){
        // Excluir uma Venda de Item da Lista e Salvar
        if (x != null){
            ISList.Remove(x);
            Close();
        } 
    }

    public static List<ItemSell> List(){
        // Retorna a Lista de Venda de Item
        Open();
        return ISList;
    }

    public static ItemSell ListId(int id){
        // Retorna uma Venda de Item que está na Lista de Venda de Item
        Open();
        foreach(ItemSell i in ISList) if (i.id == id) return i;
        return null;
    }

    public static void Update(ItemSell x){
        // Atualizar uma Venda de Item e Salvar
        ItemSell i = ListId(x.id);
        if (i != null){
            ISList.Remove(i);
            ISList.Add(x);
            Close();
        }
    }

    public static void Open(){
        // Abrir ou Criar um Arquivo .json
        ISList.Clear();
        try{
            string write = File.ReadAllText("ItemSellList.json");
            ISList = JsonSerializer.Deserialize<List<ItemSell>>(write);
        } catch (FileNotFoundException) {}
    }

    public static void Close(){
        // Salvar a Lista de Venda de Item no Arquivo .json
        string save = JsonSerializer.Serialize<List<ItemSell>>(ISList);
        File.WriteAllText("ItemSellList.json", save);
    }
}

class ItemSell
{
    public int id {get; set;}
    public int quantity {get; set;}
    public double price {get; set;}
    public int idSale {get; set;}
    public int idProduct {get; set;}

    public ItemSell(int id, int quantity, double price, int idSale, int idProduct){
        this.id = id;
        this.quantity = quantity;
        this.price = price;
        this.idSale = idSale;
        this.idProduct = idProduct;
    }

    public override string ToString(){
        return $"\nQuantidade: {quantity} \nPreço a Pagar: R${price:f2} \nNúmero de Verificação: {id}\n";
    }

}