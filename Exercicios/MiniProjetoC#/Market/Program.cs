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
                    ClientInsert();
                    break;
                case 2:
                    ClientDel();
                    break;
                case 3:
                    ClientList();
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
                    ListCategories();
                    break;
                case 8:
                    UpdateCategory();
                    break;
                case 13:
                    break;
                default:
                    Console.WriteLine("Valor Inválido! \n");
                    break;
            }
        }while(value != 13);

        Console.Clear();
        Console.WriteLine("Fim do Algoritimo!");
    }

    public static int Menu(){
        Console.WriteLine("------------------------------ Menu de Cadastro -------------------------------");
        Console.WriteLine("Clientes: [1]Inserir Cliente [2]Excluir Cliente [3]Listar Clientes [4]Atualizar Cadastro");
        Console.WriteLine("Categorias: [5]Criar Categoria [6]Excluir Categoria [7]Listar Categorias [8]Atualizar Categoria") ;
        Console.WriteLine("Produto: [9]Inserir Produto [10]Excluir Produto [11]Listar Produtos [12]Atualizar Produto");
        Console.WriteLine("\n[13]Sair");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("O Que Deseja: ");
        return int.Parse(Console.ReadLine());
    }

    public static void ClientInsert(){
        // Informações de um Novo Cliente
        Console.WriteLine("Digite o Nome do Cliente: ");
        string name = Console.ReadLine();
        Console.WriteLine("Digite o E-Mail do Cliente: "); 
        string email = Console.ReadLine();
        Console.WriteLine("Digite o Telefone do Cliente (Padrão: DD9XXXXXXXX): ") ;
        string phone = Console.ReadLine();
        Client c = new Client(0, name, email, phone);
        // Inserir Cliente na Lista de Clientes
        ListClient.Insert(c);
    }

    public static void ClientDel(){
        // Listar Clientes
        ClientList();
        // Informa o ID do Cadastro que Deseja Excluir
        Console.WriteLine("Informe o Id do Cliente que Deseja Excluir: ");
        int id = int.Parse(Console.ReadLine());
        // Deletar um Cadastro
        Client c = ListClient.ListId(id);
        ListClient.Del(c);
    }

    public static void ClientList(){
        // Listar Clientes - Sem Cliente || Lista de Clientes
        if (ListClient.List().Count() == 0){
            Console.WriteLine("Sem Clientes Cadastrados! \n");
        } else {
            Console.WriteLine("Lista de Clientes: ");
            foreach (Client i in ListClient.List()) Console.WriteLine($"{i} \n");
        }
    }

    public static void UpdateRegister(){
        // Listar Clientes
        ClientList();
        // Informa o ID do Cadastro que Deseja Atualizar
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
        Client c = new Client(id, name, email, phone);
        ListClient.Update(c);
    }

    public static void CreateCategory(){
        // Informações da Categoria
        Console.WriteLine("Informe a Descrição da Categoria(NOME): ");
        string description = Console.ReadLine();
        Category c = new Category(0, description);
        // Criar Categoria
        CategoryList.Create(c);
    }

    public static void DelCategory(){
        // Lista Categoria
        ListCategories();
        // ID da Categoria que Deseja ser Deletada
        Console.WriteLine("Informe o Número da Categoria que Deseja Excluir: ");
        int id = int.Parse(Console.ReadLine());
        // Deletar Categoria
        Category c = CategoryList.ListId(id);
        CategoryList.Del(c);
    }

    public static void ListCategories(){
        // Retorna a Lista de Categorias - Nenhuma Categoria || Lista de Categoria
        if (CategoryList.List().Count() == 0){
            Console.WriteLine("Nenhuma Categoria Encontrada! \n");
        } else {
            Console.WriteLine("Lista de Categorias: ");
            foreach (Category x in CategoryList.List()) Console.WriteLine($"{x} \n");
        }
    }

    public static void UpdateCategory(){
        // Lista de Categorias
        ListCategories();
        // Informa o ID da Categoria a ser Alterada
        Console.WriteLine("Informe o Número da Categoria que Deseja Atualizar os Dados: ");
        int id = int.Parse(Console.ReadLine());
        // Novas Informações da Categoria
        Console.WriteLine("Informe a Nova Descrição(NOME) da Categoria: ");
        string description = Console.ReadLine();
        // Substituir a Velha Categoria pela Nova
        Category c = new Category(id, description);
        CategoryList.Update(c); 
    }
}