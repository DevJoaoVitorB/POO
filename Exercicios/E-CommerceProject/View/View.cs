static class View
{
    // Criar o Cadastro de Admin
    public static void CreateAdmin(){
        bool create = false;
        foreach(Client i in List1()) if(i.name == "Admin") create = true;
        if(create != true) Insert1("Admin", "Admin@Admin.com", "84940028922", "1234");
    }
    
    // Verificar o Cadastro Informado pelo E-mail e Senha 
    public static Client Verification(string email, string password){
        foreach(Client i in List1()) if(i.email == email && i.password == password) return i;
        return null;
    }

    // 1 - Cliente
    // 2 - Categoria
    // 3 - Produto
    // 4 - Venda de Item
    // 5 - Venda

    public static void Insert1(string name, string email, string phone, string senha){
        Client x = new Client(0, name, email, phone, senha);
        ClientList.Insert(x);
    }

    public static void Insert2(string description){
        Category x = new Category(0, description);
        CategoryList.Insert(x);
    }

    public static void Insert3(string description, double price, int storage, int idCategory){
        Product x = new Product(0, description, price, storage, idCategory);
        ProductList.Insert(x);
    }

    public static int Insert4(int quantity, int idSale, int idProduct){
        Product p = List3Id(idProduct);
        if(quantity > p.storage) return 0;
        else {
            // Preço a Ser Pago pelo Pedido!
            double price = p.price * quantity;
            // Atualizar o Estoque do Produto!
            Update3(p.id, p.description, p.price, (p.storage - quantity), p.idCategory);
            // Criar o Pedido e Inserir no Carrinho!
            ItemSell x = new ItemSell(0, quantity, price, idSale, idProduct);
            ItemSellList.Insert(x);
            return 1;
        }
    }

    public static void Insert5(bool cart, double total, int idClient){
        Sale x = new Sale(0, cart, total, idClient);
        SaleList.Insert(x);
    }

    public static void Del1(int id){
        Client x = ClientList.ListId(id);
        ClientList.Del(x);
    }

    public static void Del2(int id){
        Category x = CategoryList.ListId(id);
        CategoryList.Del(x);
    }

    public static void Del3(int id){
        Product x = ProductList.ListId(id);
        ProductList.Del(x);
    }

    public static void Del4(int id){
        ItemSell x = ItemSellList.ListId(id);
        Product p = List3Id(x.idProduct);
        Update3(p.id, p.description, p.price, (x.quantity + p.storage), p.idCategory);
        ItemSellList.Del(x);
    }

    public static void Del5(int id){
        Sale x = SaleList.ListId(id);
        SaleList.Del(x);
    }

    public static List<Client> List1(){
        return ClientList.List();
    }

    public static List<Category> List2(){
        return CategoryList.List();
    }

    public static Category List2Id(int id){
        return CategoryList.ListId(id);
    }

    public static List<Product> List3(){
        return ProductList.List();
    }

    public static Product List3Id(int id){
        return ProductList.ListId(id);
    }

    public static List<ItemSell> List4(){
        return ItemSellList.List();
    }

    public static ItemSell List4Id(int id){
        return ItemSellList.ListId(id);
    }

    public static List<Sale> List5(){
        return SaleList.List();
    }

    public static Sale List5Id(int id){
        return SaleList.ListId(id);
    }

    public static void Update1(int id, string name, string email, string phone, string password){
        Client x = new Client(id, name, email, phone, password);
        ClientList.Update(x);
    }

    public static void Update2(int id, string description){
        Category x = new Category(id, description);
        CategoryList.Update(x); 
    }

    public static void Update3(int id, string description, double price, int storage, int idCategory){
        Product x = new Product(id, description, price, storage, idCategory);
        ProductList.Update(x);
    }

    public static int Update4(int id, int quantity, int idSale, int idProduct){
        ItemSell i = List4Id(id);
        Product p = List3Id(idProduct);
        if(quantity > i.quantity) return 0;
        else {
            // Preço a Ser Pago pelo Pedido!
            double price = p.price * quantity;
            // Atualizar o Estoque do Produto!
            Update3(p.id, p.description, p.price, ((i.quantity + p.storage) - quantity), p.idCategory);
            // Criar o Pedido e Inserir no Carrinho!
            ItemSell x = new ItemSell(id, quantity, price, idSale, idProduct);
            ItemSellList.Update(x);
            return 1;
        }
    }
    
    public static void Percentual(double percentual){ 
        for(int i = 0; i < List3().Count(); i++){
            Product copy = List3()[i];
            Product x = List3Id(copy.id);

            x.price = (1 + percentual) * copy.price;
            ProductList.Close();
        }
    }
}