using System.Text.Json;

static class CategoryList
{
    private static List<Category> Categories = new List<Category>();

    public static void Create(Category c){
        // Abrir Lista de Categorias
        Open();
        // Obter o Maior ID da Lista de Categorias e Somar +1
        int id = 0;
        foreach (Category x in Categories) if(x.id > id) id = x.id;
        c.id = id + 1;
        // Adicionar Categoria e Salvar
        Categories.Add(c);
        Close();
    } 

    public static void Del(Category c){
        // Remover a Categoria e Salvar
        if (c != null){
            Categories.Remove(c);
            Close();
        }
    }

    public static List<Category> List(){
        // Retorna a Lista de Categorias
        Open();
        return Categories;
    }

    public static Category ListId(int id){
        Open();
        foreach (Category c in Categories) if (c.id == id) return c;
        return null;
    }

    public static void Update(Category c){
        // Atualizar Dados da Categoria e Salvar
        Category category = ListId(c.id);
        if (category != null){
            category.description = c.description;
            Close();
        }
    }

    public static void Open(){
        // Abrir ou Criar um Arquivo .json
        Categories.Clear();
        try{
            string write = File.ReadAllText("Category.json");
            Categories = JsonSerializer.Deserialize<List<Category>>(write);
        } catch (FileNotFoundException) {}
    }

    public static void Close(){
        // Salvar a Lista de Clientes no Arquivo .json
        string save = JsonSerializer.Serialize<List<Category>>(Categories);
        File.WriteAllText("Category.json", save);
    }
}

class Category
{
    public int id {get; set;}
    public string description {get; set;}

    public Category(int id, string description){
        this.id = id;
        this.description = description;
    }

    public override string ToString(){
        return $"Categoria {id}: \nDescrição: {description}\n";
    }
}