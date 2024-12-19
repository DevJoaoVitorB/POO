using System.Text.Json;

static class ProductList
{
    private static List<Product> Products = new List<Product>(); // Lista de Produtos

    public static void Insert(Product x){
        // Abrir Lista de Produtos
        Open();
        // Obter o Maior ID da Lista de Produtos e Somar +1
        int id = 0;
        foreach (Product i in Products) if (i.id > id) id = i.id;
        x.id = id + 1;
        // Adicionar Produto e Salvar
        Products.Add(x);
        Close();
    }

    public static void Del(Product x){
        // Excluir Produto e Salvar
        if (x != null){
            Products.Remove(x);
            Close();
        } 
    }

    public static List<Product> List(){
        // Retorna a Lista de Produtos
        Open();
        return Products;
    }

    public static Product ListId(int id){
        // Retorna um Produto que está na Lista de Produto
        Open();
        foreach(Product i in Products) if (i.id == id) return i;
        return null;
    }

    public static void Update(Product x){
        // Atualizar Dados de um Produto e Salvar
        Product i = ListId(x.id);
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
            string write = File.ReadAllText("ProductList.json");
            Products = JsonSerializer.Deserialize<List<Product>>(write);
        } catch (FileNotFoundException) {}
    }

    public static void Close(){
        // Salvar a Lista de Produtos no Arquivo .json
        string save = JsonSerializer.Serialize<List<Product>>(Products);
        File.WriteAllText("ProductList.json", save);
    }
}

class Product
{
    public int id { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    public int storage { get; set; }
    public int idCategory { get; set; }

    public Product(int id, string description, double price, int storage, int idCategory){
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