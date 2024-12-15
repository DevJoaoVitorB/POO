IndexUI.MainUI();
static class IndexUI
{
    private static int id = 0; // ID da Pessoa Cadastrada
    private static string name = ""; // NOME da Pessoa Cadastrada

    // Corpo Principal do Algoritmo
    public static void MainUI(){
        View.CreateAdmin();
        int value = 0;
        do{
            if(id == 0) value = VisitorUI();
            else {
                Console.WriteLine($"Bem-Vindo ao E-Commerce {name}!");
                if (name == "Admin") value = AdminUI();
                else value = ClientUI();
            }
        }while(value != 99);
    }

    // Interface de Usuário para Visitantes
    public static int VisitorUI(){
        int value = 0;
        value = MenuVisitor();
        Console.Clear();

        switch (value){
            case 1:
                Client x = OPClient.VerificationClient();
                if(x != null) {
                    id = x.id;
                    name = x.name;
                }
                break;
            case 2:
                OPClient.InsertClient();
                Console.Clear();
                break;
            case 99:
                break;
            default:
                Console.WriteLine("Valor Inválido!");
                break;
        }

        return value;
    }
    // Interface do Usuário para Administrador
    public static int AdminUI(){
        int value = 0;
        value = MenuAdmin();
        Console.Clear();

        switch (value){
            case 1:
                OPClient.InsertClient();
                break;
            case 2:
                OPClient.DelClient();
                break;
            case 3:
                OPClient.ListC1();
                break;
            case 4:
                OPClient.UpdateRegister();
                break;
            case 5:
                OPCategory.CreateCategory();
                break;
            case 6:
                OPCategory.DelCategory();
                break;
            case 7:
                OPCategory.ListC2();
                break;
            case 8:
                OPCategory.UpdateCategory();
                break;
            case 9:
                OPProduct.CreateProduct();
                break;
            case 10:
                OPProduct.DelProduct();
                break;
            case 11:
                OPProduct.ListP();
                break;
            case 12:
                OPProduct.UpdateProduct();
                break;
            case 13:
                OPProduct.PricePercentage();
                break;
            case 15:
                Console.WriteLine("As Operações de Cliente, Categoria e Produtos foram Salvas!");
                id = 0;
                name = "";
                break;
            case 99:
                break;
            default:
                Console.WriteLine("Valor Inválido! \n");
                break;
        }

        return value;
    }
    // Interface de Usuário para Clientes
    public static int ClientUI(){
        int value = 0;
        value = MenuClient();
        Console.Clear();

        switch (value){
            case 1:
                OPProduct.ListP();
                break;
            case 2:
                OPSale.MyCart(id);
                break;
            case 3:
                OPSale.MakeSale(id);
                break;
            case 4:
                OPSale.ListSale(id);
                break;
            case 5:
                Console.WriteLine($"Obrigado pelas Compras {name}!");
                id = 0;
                name = "";
                break;
            case 99:
                break;
            default:
                Console.WriteLine("Valor Inválido! \n");
                break;
        }

        return value;
    }

    // Menu de Escolhas para Visitantes/Página de Login
    public static int MenuVisitor(){
        Console.WriteLine("------------------------------ Login -------------------------------");
        Console.WriteLine("Clientes: [1]Fazer Login [2]Cadastrar");
        Console.WriteLine("\n[99]Sair do Sistema");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("O Que Deseja: ");
        return int.Parse(Console.ReadLine());
    }
    // Menu de Escolha para Administrador/Conta de Admin
    public static int MenuAdmin(){
        Console.WriteLine("------------------------------ Menu de Admin -------------------------------");
        Console.WriteLine("Clientes: [1]Inserir Cliente [2]Excluir Cliente [3]Listar Clientes [4]Atualizar Cadastro");
        Console.WriteLine("Categorias: [5]Criar Categoria [6]Excluir Categoria [7]Listar Categorias [8]Atualizar Categoria") ;
        Console.WriteLine("Produto: [9]Inserir Produto [10]Excluir Produto [11]Listar Produtos [12]Atualizar Produto [13]Reajuste de Preço(GERAL)");
        Console.WriteLine("\n[15]Login [99]Sair do Sistema");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("O Que Deseja: ");
        return int.Parse(Console.ReadLine());
    }
    // Menu de Escolha para Clientes/Sistema de Compras
    public static int MenuClient(){
        Console.WriteLine("------------------------------ Menu Cliente -------------------------------");
        Console.WriteLine("Operações: [1]Listar Produtos [2]Meu Carrinho [3]Fechar Pedidos [4]Ver Meus Pedidos");
        Console.WriteLine("\n[5]Login [99]Sair do Sistema");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("O Que Deseja: ");
        return int.Parse(Console.ReadLine());
    }
}