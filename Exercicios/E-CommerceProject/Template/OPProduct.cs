static class OPProduct
{
    public static void CreateProduct(){
        // Informações do Produto
        Console.WriteLine("Informe a Descrição(NOME) do Produto: ");
        string description = Console.ReadLine();
        Console.Write("Informe o Preço do Produto: R$");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a Quantidade em Estoque do Produto: ");
        int storage = int.Parse(Console.ReadLine());
        OPCategory.ListC2();
        Console.WriteLine("Informe o ID da Categoria do Produto: ");
        int idCategory = int.Parse(Console.ReadLine());
        // Criar Produto
        View.Insert3(description, price, storage, idCategory);
    }
    public static void DelProduct(){
        // Listar Produto
        ListP();
        // ID do Produto a ser Deletado
        Console.WriteLine("Informe o Número do Produto a ser Excluido: ");
        int id = int.Parse(Console.ReadLine());
        // Deletar o Produto
        View.Del3(id);
    }
    public static void ListP(){
        // Retorna a Lista de Produtos - Nenhum Produto || Lista de Produtos
         if (View.List3().Count() == 0){
            Console.WriteLine("Nenhum Produto Encontrado! \n");
        } else {
            Console.WriteLine("Lista de Produtos: ");
            foreach (Product i in View.List3()){
                int idCategory = i.idCategory;
                Category category = View.List2Id(idCategory);
                Console.WriteLine($"{i}{category.description} \n");
            }
        }
    }
    public static void UpdateProduct(){
        // Lista Produtos
        ListP();
        // Informa o ID do Produto a ser Atualizado
        Console.WriteLine("Informe o Número do Produto que Deseja Atualizar os Dados: ");
        int id = int.Parse(Console.ReadLine());
        // Novas Informações do Produto
        Console.WriteLine("Informe a nova Descrição(NOME) do Produto: ");
        string description = Console.ReadLine();
        Console.Write("Informe o novo Preço do Produto: R$");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a nova Quantidade em Estoque do Produto: ");
        int storage = int.Parse(Console.ReadLine());
        OPCategory.ListC2();
        Console.WriteLine("Informe o Número da Nova Categoria do Produto: ");
        int idCategory = int.Parse(Console.ReadLine());
        // Substituir o Velho Produto pelo Novo
        View.Update3(id, description, price, storage, idCategory);
    }

    public static void PricePercentage(){
        // Valor de Reajuste Geral dos Produtos
        Console.WriteLine("Informe o Percentual de Ajuste Geral dos Preços em %: ");
        double percentual = double.Parse(Console.ReadLine());
        // Passar o Reajuste para o Preço dos Produtos
        View.Percentual((double)percentual/100);
    }
}