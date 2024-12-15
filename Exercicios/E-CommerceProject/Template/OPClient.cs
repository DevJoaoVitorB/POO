static class OPClient
{
    public static Client VerificationClient(){
        // Informações para Verificar Cliente Cadastrado
        Console.WriteLine("Informe o Email do Cliente: ");
        string email = Console.ReadLine();
        Console.WriteLine("Informe a Senha do Cliente: ");
        string password = Console.ReadLine();
        Client x = View.Verification(email, password);
        // Verificação do Email e Senha do Cliente
        if(x == null) Console.WriteLine("Usuário não Encontrado, Senha ou Email Inválidos!");
        else {
            int value = 0;
            foreach(Sale s in View.List5()){
                if(s.idClient == x.id && s.cart == true) value = 1;  
            } 
            if(value != 1 && email != "Admin@Admin.com") View.Insert5(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"), true, 0, x.id);
            return x;
        }
        return null;
    }

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
        int verification = 0;
        foreach(Client c in View.List1()) if(c.email == email) verification = 1;
        if (verification == 1) Console.WriteLine("Há um Cliente Cadastrado com esse E-Mail!");
        else View.Insert1(name, email, phone, password);
    } 
    public static void DelClient(){
        if(View.List1().Count() == 0) ListC1();
        else {
            // Listar Clientes
            ListC1();
            // ID do Cadastro a ser Excluir
            Console.WriteLine("Informe o Id do Cliente que Deseja Excluir: ");
            int id = int.Parse(Console.ReadLine());
            // Deletar um Cadastro
            View.Del1(id);
        }
    }
    public static void ListC1(){
        // Listar Clientes - Sem Cliente || Lista de Clientes
        if (View.List1().Count() == 0){
            Console.WriteLine("Sem Clientes Cadastrados! \n");
        } else {
            Console.WriteLine("Lista de Clientes: ");
            foreach (Client c in View.List1()) Console.WriteLine($"{c}");
        }
    }
    public static void UpdateRegister(){
        if(View.List1().Count() == 0) ListC1();
        else {
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
}