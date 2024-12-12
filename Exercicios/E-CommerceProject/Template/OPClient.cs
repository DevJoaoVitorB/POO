static class OPClient
{
    public static void InsertClient(){
        // Informações de um Novo Cliente
        Console.WriteLine("Digite o Nome do Cliente: ");
        string name = Console.ReadLine();
        Console.WriteLine("Digite o E-Mail do Cliente: "); 
        string email = Console.ReadLine();
        Console.WriteLine("Digite o Telefone do Cliente (Padrão: DD9XXXXXXXX): ") ;
        string phone = Console.ReadLine();
        Console.WriteLine("Digite a Senha do Cliente: ");
        string password = Console.ReadLine();
        // Inserir Cliente na Lista de Clientes
        View.Insert1(name, email, phone, password);
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
        Console.WriteLine("Digite a Nova Senha do Cliente: ");
        string password = Console.ReadLine();
        // Criar Novo Cliente e Substituir o Velho pelo Novo
        View.Update1(id, name, email, phone, password);
    }
}