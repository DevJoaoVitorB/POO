static class OPCategory
{
    public static void CreateCategory(){
        // Informações da Categoria
        Console.WriteLine("Informe a Descrição da Categoria(NOME): ");
        string description = Console.ReadLine();
        // Criar Categoria
        View.Insert2(description);
    }
    public static void DelCategory(){
        // Lista Categoria
        ListC2();
        // ID da Categoria a ser Deletada
        Console.WriteLine("Informe o Número da Categoria que Deseja Excluir: ");
        int id = int.Parse(Console.ReadLine());
        // Deletar Categoria
        View.Del2(id);
    }
    public static void ListC2(){
        // Retorna a Lista de Categorias - Nenhuma Categoria || Lista de Categoria
        if (View.List2().Count() == 0){
            Console.WriteLine("Nenhuma Categoria Encontrada! \n");
        } else {
            Console.WriteLine("Lista de Categorias: ");
            foreach (Category c in View.List2()) Console.WriteLine($"{c} \n");
        }
    }
    public static void UpdateCategory(){
        // Lista de Categorias
        ListC2();
        // ID da Categoria a ser Atualizada
        Console.WriteLine("Informe o Número da Categoria que Deseja Atualizar os Dados: ");
        int id = int.Parse(Console.ReadLine());
        // Novas Informações da Categoria
        Console.WriteLine("Informe a Nova Descrição(NOME) da Categoria: ");
        string description = Console.ReadLine();
        // Substituir a Velha Categoria pela Nova
        View.Update2(id, description);
    }
}