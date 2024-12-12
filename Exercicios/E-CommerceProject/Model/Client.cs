using System.Text.Json;

static class ClientList
{
    private static List<Client> Clients = new List<Client>();

    public static void Insert(Client x){
        // Abrir Lista de Clientes
        Open();
        // Obter o Maior ID da Lista de Clientes e Somar +1
        int id = 0;
        foreach (Client c in Clients) if (c.id > id) id = c.id;
        x.id = id + 1;
        // Adicionar Cliente e Salvar
        Clients.Add(x);
        Close();
    }

    public static void Del(Client x){
        // Excluir Cadastro e Salvar
        if (x != null){
            Clients.Remove(x);
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

    public static void Update(Client x){
        // Atualizar Cadastro e Salvar
        Client c = ListId(x.id);
        if (c != null){
            Clients.Remove(c);
            Clients.Add(x);
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
    public string password { get; set; }

    public Client(){}
    public Client(int id, string name, string email, string phone, string password){
        this.id = id;
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.password = password;
    }

    public override string ToString(){
        return $"Nome: {name} \nEmail: {email} \nTelefone: {phone} \nID[{id}] \n";
    }
}
