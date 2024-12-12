using System.Text.Json;

static class ItemList
{
    private static List<Item> Products = new List<Item>();

    public static void Insert(Item x){
        // Abrir Lista de Produtos
        Open();
        // Obter o Maior ID da Lista de Produtos e Somar +1
        int id = 0;
        foreach (Item i in Products) if (i.id > id) id = i.id;
        x.id = id + 1;
        // Adicionar Produto e Salvar
        Products.Add(x);
        Close();
    }

    public static void Del(Item x){
        // Excluir Produto e Salvar
        if (x != null){
            Products.Remove(x);
            Close();
        } 
    }

    public static List<Item> List(){
        // Retorna a Lista de Produtos
        Open();
        return Products;
    }

    public static Item ListId(int id){
        // Retorna um Produto que está na Lista de Produto
        Open();
        foreach(Item i in Products) if (i.id == id) return i;
        return null;
    }

    public static void Update(Item x){
        // Atualizar Dados de um Produto e Salvar
        Item i = ListId(x.id);
        if (i != null){
            Products.Remove(i);
            Products.Add(x);
            Close();
        }
    }

    public static void Open(){
        // Abrir ou Criar um Arquivo .json
        Products.Clear();
        try{
            string write = File.ReadAllText("ItemList.json");
            Products = JsonSerializer.Deserialize<List<Item>>(write);
        } catch (FileNotFoundException) {}
    }

    public static void Close(){
        // Salvar a Lista de Produtos no Arquivo .json
        string save = JsonSerializer.Serialize<List<Item>>(Products);
        File.WriteAllText("ItemList.json", save);
    }
}

class Item
{
    public int id { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    public int storage { get; set; }
    public int idCategory { get; set; }

    public Item(int id, string description, double price, int storage, int idCategory){
        this.id = id;
        this.description = description;
        this.price = price;
        this.storage = storage;
        this.idCategory = idCategory;
    }

    public override string ToString(){
        return $"Produto {id}: \nDescrição: {description} \nPreço: R${price:f2} \nQuantidade: {storage} \nCategoria: ";
    }
}