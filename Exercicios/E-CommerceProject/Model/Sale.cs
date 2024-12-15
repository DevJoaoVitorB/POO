using System.Text.Json;

static class SaleList
{
    private static List<Sale> SList = new List<Sale>(); // Lista de Vendas

    public static void Insert(Sale x){
        // Abrir Lista de Vendas
        Open();
        // Obter o Maior ID da Lista de Vendas e Somar +1
        int id = 0;
        foreach (Sale s in SList) if (s.id > id) id = s.id;
        x.id = id + 1;
        // Adicionar uma Venda e Salvar
        SList.Add(x);
        Close();
    }

    public static void Del(Sale x){
        // Excluir uma Venda da Lista e Salvar
        if (x != null){
            SList.Remove(x);
            Close();
        } 
    }

    public static List<Sale> List(){
        // Retorna a Lista de Vendas
        Open();
        return SList;
    }

    public static Sale ListId(int id){
        // Retorna uma Venda que está na Lista de Vendas
        Open();
        foreach(Sale s in SList) if (s.id == id) return s;
        return null;
    }

    public static void Update(Sale x){
        // Atualizar uma Venda e Salvar
        Sale s = ListId(x.id);
        if (s != null){
            SList.Remove(s);
            SList.Add(x);
            Close();
        }
    }

    public static void Open(){
        // Abrir ou Criar um Arquivo .json
        SList.Clear();
        try{
            string write = File.ReadAllText("SaleList.json");
            SList = JsonSerializer.Deserialize<List<Sale>>(write);
        } catch (FileNotFoundException) {}
    }

    public static void Close(){
        // Salvar a Lista de Vendas no Arquivo .json
        string save = JsonSerializer.Serialize<List<Sale>>(SList);
        File.WriteAllText("SaleList.json", save);
    }
}

class Sale
{
    public int id {get; set;}
    public object day {get; set;}
    public bool cart {get; set;}
    public double total {get; set;}
    public int idClient {get; set;}

    public Sale(int id, bool cart, double total, int idClient){
        this.id = id;
        this.cart = cart;
        this.total = total;
        this.idClient = idClient;
        day = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
    }

    public override string ToString(){
        return $"COMPRA {id}: \n\tDia da Compra: {day} \n\tTotal a Pagar: R${total:f2} \n\tStatus do Carrinho: {cart}";
    }
}