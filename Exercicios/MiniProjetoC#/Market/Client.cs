using System.Text.Json;

static class ListClient
{
    private static List<Client> Clients = new List<Client>();

    public static void Insert(Client c){
        // Abrir Lista de Categorias
        Open();
        // Obter o Maior ID da Lista de Clientes e Somar +1
        int id = 0;
        foreach (Client client in Clients) if (client.id > id) id = client.id;
        c.id = id + 1;
        // Adicionar Cliente e Salvar
        Clients.Add(c);
        Close();
    }

    public static void Del(Client c){
        // Excluir Cadastro e Salvar
        if (c != null){
            Clients.Remove(c);
            Close();
        } 
    }

    public static List<Client> List(){
        // Retorna a Lista de Clientes
        Open();
        return Clients;
    }

    public static Client ListId(int id){
        // Retorna um Cliente que está na Lista de Clientes
        Open();
        foreach(Client c in Clients) if (c.id == id) return c;
        return null;
    }

    public static void Update(Client c){
        // Atualizar Cadastro e Salvar
        Client client = ListId(c.id);
        if (client != null){
            client.name = c.name;
            client.email = c.email;
            client.phone = c.phone;
            Close();
        }
    }

    public static void Open(){
        // Abrir ou Criar um Arquivo .json
        Clients.Clear();
        try{
            string write = File.ReadAllText("ClientList.json");
            Clients = JsonSerializer.Deserialize<List<Client>>(write);
        } catch (FileNotFoundException) {}
    }

    public static void Close(){
        // Salvar a Lista de Clientes no Arquivo .json
        string save = JsonSerializer.Serialize<List<Client>>(Clients);
        File.WriteAllText("ClientList.json", save);
    }
}

class Client
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }

    public Client(){}
    public Client(int id, string name, string email, string phone){
        this.id = id;
        this.name = name;
        this.email = email;
        this.phone = phone;
    }

    public override string ToString(){
        return $"Nome: {name} \nEmail: {email} \nTelefone: {phone} \nID[{id}] \n";
    }
}
