Menu.Choice();

static class Menu
{
    private static string name, CPF;
    private static double limit;
    private static int value, v, x, y;
    private static Enterprise startup = new Enterprise();
    private static Client c = new Client();
    private static List<Client> Clients = new List<Client>(); 
    
    public static void Choice(){
        Console.WriteLine("--- Sistema de Cadastro de Associação ---");
        Console.WriteLine("Digite o Nome da Empresa: ");
        startup = new Enterprise(Console.ReadLine());
        do{
            Console.WriteLine("\nEscolha - [1]Cadastrar Cliente [2]Listar Clientes [3]Criar Associação [4]Cadastrar Nova Empresa [5]Sair: ");
            value = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (value){
                case 1:
                    Console.WriteLine("Digite o Nome do Cliente: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do Cliente (Padrão: XXX.XXX.XXX-XX): ");
                    CPF = Console.ReadLine();
                    Console.WriteLine("Digite o Limite de Crédito do Cliente: ");
                    limit = double.Parse(Console.ReadLine());
                    c = new Client(name, CPF, limit);
                    startup.Insert(c);
                    break;
                case 2:
                    Console.WriteLine("Lista de Clientes: \n");
                    foreach(Client i in startup.List()) Console.WriteLine($"{i}");
                    break;
                case 3:
                    Console.WriteLine("Lista de Clientes: \n");
                    foreach(Client i in startup.List()) Console.WriteLine($"{i} \nNúmero de Verificação: {v++}");
                    v = 0;
                    
                    Clients = startup.List();
                    Console.WriteLine("\n Escolha o número de verificação de dois Clientes para fazer a Associação: \n");
                    Console.WriteLine("Número de Verificação - Cliente 1º: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Número de Verificação - Cliente 2º: ");
                    y = int.Parse(Console.ReadLine());

                    Clients[x].SetAssociate(Clients[y]);
                    break;
                case 4:
                    Console.WriteLine("Digite o Nome da Nova Empresa: ");
                    startup = new Enterprise(Console.ReadLine());
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Valor Inválido \n");
                    break;
            }
        }while(value != 5);

        Console.Clear();
        Console.WriteLine("Fim do Algoritimo!");
    }
}