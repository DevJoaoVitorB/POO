static class OPSale
{
    public static void MyCart(int id){
        // Menu de Operações do Carrinho
        Console.WriteLine("\n------------- Carrinho -------------");
        Console.WriteLine("Operações: [1]Inserir Produto [2]Retirar Produtos [3]Atualizar Produtos [4]Ver Carrinho");
        Console.Write("Operação: ");
        int value = int.Parse(Console.ReadLine());

        switch(value){
            case 1:
                InsertCart(id);
                break;
            case 2:
                DelCart(id);
                break;
            case 3:
                UpdateCart(id);
                break;
            case 4:
                ListCart(id);
                break;
            default:
                Console.WriteLine("Valor Inválido!");
                break;
        }
    }

    public static void InsertCart(int id){
        if (View.List3().Count() == 0) OPProduct.ListP();
        else {
            // Pegar o Id de Venda do Cliente
            int idSale = 0;
            foreach(Sale s in View.List5()) if(s.idClient == id && s.cart == true) idSale = s.id;
            // Informações do Produto a ser Adicionado ao Carrinho
            OPProduct.ListP();
            Console.WriteLine("Informe o Número do Produto que deseja: ");
            int idProduct = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Quantidade do Produto que deseja Comprar: ");
            int quantity = int.Parse(Console.ReadLine());
            // Inserir Produto no Carrinho
            int value = View.Insert4(quantity, idSale, idProduct);
            if(value == 0){
                Console.WriteLine("A Quantidade Informada Excedeu a Quantidade do Produto em Estoque! \n");
            }
        }
    }

    public static void DelCart(int id){
        int value = 0;
        foreach(ItemSell i in View.List4()){Sale s = View.List5Id(i.idSale); if(s.idClient == id && s.cart == true) value = 1;} 
        if(View.List4().Count() == 0 || value == 0) ListCart(id);
        else {
            // Produto a ser Retirado do Carrinho
            ListCart(id);
            Console.WriteLine("Informe o Número de Verificação do Produto a ser Retirado do Carrinho: ");
            int idItemSell = int.Parse(Console.ReadLine());
            // Retirar o Produto do Carrinho
            View.Del4(idItemSell);
        }
    }

    public static void ListCart(int id){
        // Listar os Produtos do Carrinho - Carrinho Vazio || Carrinho
        int value = 0;
        foreach(ItemSell i in View.List4()){Sale s = View.List5Id(i.idSale); if(s.idClient == id) value = 1;} 
        if(View.List4().Count() == 0 || value == 0) ListCart(id);
        else{
            Console.WriteLine("Meu Carrinho: ");
            foreach(ItemSell i in View.List4()){
                Sale s = View.List5Id(i.idSale); 
                if(s.idClient == id && s.cart == true){
                    Product p = View.List3Id(i.idProduct);
                    Console.WriteLine($"Produto: {p.description}{i} \n");    
                }
            } 
        }
    }

    public static void UpdateCart(int id){
        int v = 0;
        foreach(ItemSell i in View.List4()){Sale s = View.List5Id(i.idSale); if(s.idClient == id && s.cart == true) v = 1;} 
        if(View.List4().Count() == 0 || v == 0) ListCart(id);
        else {
            // O Produto a ser Atualizado no Carrinho
            ListCart(id);
            Console.WriteLine("Informe o Número de Verificação do Produto a ser Atualizado no Carrinho: ");
            int idItemSell = int.Parse(Console.ReadLine());
            ItemSell x = View.List4Id(idItemSell);
            // Novos Dados do Produto no Carrinho
            OPProduct.ListP();
            Console.WriteLine("Informe o Novo Número do Produto que deseja: ");
            int idProduct = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nova Quantidade do Produto que deseja Comprar: ");
            int quantity = int.Parse(Console.ReadLine());
            // Atualizar um Produto do Carrinho
            int value = View.Update4(x.id, quantity, x.idSale, idProduct);
            if(value == 0){
                Console.WriteLine("A Quantidade Informada Excedeu a Quantidade do Produto em Estoque!");
            }
        }
    }

    public static void MakeSale(int id){
        // Preparar a Venda
        int v1 = 0;
        foreach(ItemSell i in View.List4()){Sale s = View.List5Id(i.idSale); if(s.idClient == id && s.cart == true) v1 = 1;} 
        if(View.List4().Count() == 0 || v1 == 0) ListCart(id);
        else {
            int idSale = 0;
            foreach(Sale s in View.List5()) if(s.idClient == id && s.cart == true) idSale = s.id;
            Sale x = View.List5Id(idSale);
            foreach(ItemSell i in View.List4()) if(x.id == i.idSale) x.total += i.price;
            // Mostrar Carinho e Total da Compra
            ListCart(id);
            Console.WriteLine($"{x} \n");
            Console.WriteLine("Deseja Finalizar a Compra? [1]Sim [2]Não");
            Console.Write("Finalizar: ");
            int value = int.Parse(Console.ReadLine());
            
            // Validação da Compra
            switch(value){
                case 1:
                    int v = 0;
                    foreach(ItemSell i in View.List4()){
                        foreach(Product p in View.List3()) if(i.idProduct == p.id && p.storage < i.quantity) {v = 1; Console.WriteLine($"Falta de Estoque para: {p.description}\n");} 
                    }
                    if(v != 1){
                        // Fechar Venda
                        View.Update5(x.id, DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"), false, x.total, x.idClient);
                        // Atualizar o Estoque dos Produtos que foram Vendidos
                        foreach(ItemSell i in View.List4()){
                            Sale Sa = View.List5Id(i.idSale);
                            if(Sa.idClient == id){
                                Product y = View.List3Id(i.idProduct);
                                View.Update3(y.id, y.description, y.price, (y.storage - i.quantity), y.idCategory);
                            } 
                        }
                        // Criar Nova Venda para o Usuário
                        View.Insert5(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"), true, 0, id);
                    }
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Valor Inválido!");
                    break;
            }
        }
    }

    public static void ListSale(int id){
        foreach(Sale s in View.List5()) if(s.idClient == id) Console.WriteLine($"{s}");
    }

    public static void ListSaleAdmin(){
        if(View.List5().Count() == 0) Console.WriteLine("Nenhuma Venda Encontrada!");
        else foreach(Sale s in View.List5()){Client x = View.List1Id(s.idClient); Console.WriteLine($"\n\tCLIENTE: {x.name} \n\t{s}");}
    }

}