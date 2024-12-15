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
            int idS = 0;
            foreach(Sale s in View.List5()) if(s.idClient == id && s.cart == true) idS = s.id;
            // Informações do Produto a ser Adicionado ao Carrinho
            OPProduct.ListP();
            Console.WriteLine("Informe o Número do Produto que deseja: ");
            int idP = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Quantidade do Produto que deseja Comprar: ");
            int quantity = int.Parse(Console.ReadLine());
            // Inserir Produto no Carrinho
            int value = View.Insert4(quantity, idS, idP);
            if(value == 0){
                Console.WriteLine("A Quantidade Informada Excedeu a Quantidade do Produto em Estoque! \n");
            }
        }
    }

    public static void DelCart(int id){
        if(View.List4().Count() == 0) ListCart(id);
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
        if(View.List4().Count() == 0) Console.WriteLine("Carrinho Vazio! \n");
        else{
            Console.WriteLine("Meu Carrinho: ");
            foreach(ItemSell i in View.List4()){
                Sale s = View.List5Id(i.idSale); 
                if(s.idClient == id){
                    Product p = View.List3Id(i.idProduct);
                    Console.WriteLine($"Produto: {p.description}{i} \n");    
                }
            } 
        }
    }

    public static void UpdateCart(int id){
        if (View.List4().Count() == 0) ListCart(id);
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

    }

    public static void ListSale(int id){
        foreach(Sale s in View.List5()) if(s.idClient == id) Console.WriteLine($"{s}");
    }

}