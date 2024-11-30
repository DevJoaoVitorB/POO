UI.MainMarket();

static class UI
{
    public static void MainMarket(){
        int value = 0;
        do{
            value = Menu();
            Console.Clear();

            switch (value){
                case 1:
                    InsertClient();
                    break;
                case 2:
                    DelClient();
                    break;
                case 3:
                    ListC1();
                    break;
                case 4:
                    UpdateRegister();
                    break;
                case 5:
                    CreateCategory();
                    break;
                case 6:
                    DelCategory();
                    break;
                case 7:
                    ListC2();
                    break;
                case 8:
                    UpdateCategory();
                    break;
                case 9:
                    CreateItem();
                    break;
                case 10:
                    DelItem();
                    break;
                case 11:
                    ListI();
                    break;
                case 12:
                    UpdateItem();
                    break;
                case 13:
                    PricePercentage();
                    break;
                case 15:
                    break;
                default:
                    Console.WriteLine("Valor Inválido! \n");
                    break;
            }
        }while(value != 15);

        Console.Clear();
        Console.WriteLine("Fim do Algoritimo!");
    }

    public static int Menu(){
        Console.WriteLine("------------------------------ Menu de Cadastro -------------------------------");
        Console.WriteLine("Clientes: [1]Inserir Cliente [2]Excluir Cliente [3]Listar Clientes [4]Atualizar Cadastro");
        Console.WriteLine("Categorias: [5]Criar Categoria [6]Excluir Categoria [7]Listar Categorias [8]Atualizar Categoria") ;
        Console.WriteLine("Produto: [9]Inserir Produto [10]Excluir Produto [11]Listar Produtos [12]Atualizar Produto [13]Reajuste de Preço(GERAL)");
        Console.WriteLine("\n[15]Sair");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("O Que Deseja: ");
        return int.Parse(Console.ReadLine());
    }

    public static void InsertClient(){
        // Informações de um Novo Cliente
        Console.WriteLine("Digite o Nome do Cliente: ");
        string name = Console.ReadLine();
        Console.WriteLine("Digite o E-Mail do Cliente: "); 
        string email = Console.ReadLine();
        Console.WriteLine("Digite o Telefone do Cliente (Padrão: DD9XXXXXXXX): ") ;
        string phone = Console.ReadLine();
        // Inserir Cliente na Lista de Clientes
        View.Insert1(0, name, email, phone);
    }

    public static void DelClient(){
        // Listar Clientes
        ListC1();
        // ID do Cadastro a ser Excluir
        Console.WriteLine("Informe o Id do Cliente que Deseja Excluir: ");
        int id = int.Parse(Console.ReadLine());
        // Deletar um Cadastro
        View.Del1(id);
    }

    public static void ListC1(){
        // Listar Clientes - Sem Cliente || Lista de Clientes
        if (View.List1().Count() == 0){
            Console.WriteLine("Sem Clientes Cadastrados! \n");
        } else {
            Console.WriteLine("Lista de Clientes: ");
            foreach (Client c in View.List1()) Console.WriteLine($"{c} \n");
        }
    }

    public static void UpdateRegister(){
        // Listar Clientes
        ListC1();
        // ID do Cadastro a ser Atualizado
        Console.WriteLine("Informe o Id do Cliente que Deseja Atualizar os Dados: ");
        int id = int.Parse(Console.ReadLine());
        // Novas Informações de Cadastro
        Console.WriteLine("Digite o Novo Nome do Cliente: ");
        string name = Console.ReadLine();
        Console.WriteLine("Digite o Novo E-Mail do Cliente: "); 
        string email = Console.ReadLine();
        Console.WriteLine("Digite o Novo Telefone do Cliente (Padrão: DD9XXXXXXXX): ");
        string phone = Console.ReadLine();
        // Criar Novo Cliente e Substituir o Velho pelo Novo
        View.Update1(id, name, email, phone);
    }

    public static void CreateCategory(){
        // Informações da Categoria
        Console.WriteLine("Informe a Descrição da Categoria(NOME): ");
        string description = Console.ReadLine();
        // Criar Categoria
        View.Insert2(0, description);
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

    public static void CreateItem(){
        // Informações do Produto
        Console.WriteLine("Informe a Descrição(NOME) do Produto: ");
        string description = Console.ReadLine();
        Console.Write("Informe o Preço do Produto: R$");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a Quantidade em Estoque do Produto: ");
        int storage = int.Parse(Console.ReadLine());
        ListC2();
        Console.WriteLine("Informe o ID da Categoria do Produto: ");
        int idCategory = int.Parse(Console.ReadLine());
        // Criar Produto
        View.Insert3(0, description, price, storage, idCategory);
    }

    public static void DelItem(){
        // Listar Produto
        ListI();
        // ID do Produto a ser Deletado
        Console.WriteLine("Informe o Número do Produto a ser Excluido: ");
        int id = int.Parse(Console.ReadLine());
        // Deletar o Produto
        View.Del3(id);
    }

    public static void ListI(){
        // Retorna a Lista de Produtos - Nenhum Produto || Lista de Produtos
         if (View.List3().Count() == 0){
            Console.WriteLine("Nenhum Produto Encontrada! \n");
        } else {
            Console.WriteLine("Lista de Produtos: ");
            foreach (Item i in View.List3()) Console.WriteLine($"{i} \n");
        }
    }

    public static void UpdateItem(){
        // Lista Produtos
        ListI();
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
        ListC2();
        Console.WriteLine("Informe o Número da Nova Categoria do Produto: ");
        int idCategory = int.Parse(Console.ReadLine());
        // Substituir o Velho Produto pelo Novo
        View.Update3(id, description, price, storage, idCategory);
    }

    public static void PricePercentage(){
        // Valor de Reajuste Geral dos Produtos
        Console.WriteLine("Informe o Percentual de Ajuste Geral dos Preços: ");
        double percentual = double.Parse(Console.ReadLine());
        // Passar o Reajuste para o Preço dos Produtos
        View.Percentual(percentual);
    }
}