static class View
{
    // 1 - Cliente
    // 2 - Categoria
    // 3 - Produto

    public static void Insert1(string name, string email, string phone, string senha){
        Client x = new Client(0, name, email, phone, senha);
        ClientList.Insert(x);
    }

    public static void Insert2(string description){
        Category x = new Category(0, description);
        CategoryList.Insert(x);
    }

    public static void Insert3(string description, double price, int storage, int idCategory){
        Item x = new Item(0, description, price, storage, idCategory);
        ItemList.Insert(x);
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
        Item x = ItemList.ListId(id);
        ItemList.Del(x);
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

    public static List<Item> List3(){
        return ItemList.List();
    }

    public static Item List3Id(int id){
        return ItemList.ListId(id);
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
        Item x = new Item(id, description, price, storage, idCategory);
        ItemList.Update(x);
    }

    public static void Percentual(double percentual){ 
        for(int i = 0; i < List3().Count(); i++){
            Item copy = List3()[i];
            Item x = List3Id(copy.id);

            x.price = (1 + percentual) * copy.price;
            ItemList.Close();
        }
    }
}