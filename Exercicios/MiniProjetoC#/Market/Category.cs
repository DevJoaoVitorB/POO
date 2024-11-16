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

    public static void Update(Client c){
        // Atualizar Dados da Categoria e Salvar
        Category category = ListId(c.id);
        if (category != null){
            category.description = c.description;
            Close();
        }
    }
}

class Category
{

}