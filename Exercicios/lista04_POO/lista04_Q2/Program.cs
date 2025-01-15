Menu.Choice();
static class Menu
{
    private static int value;
    private static string name, description, artist, album;
    private static Playlist p = new Playlist();
    public static void Choice(){
        do{
            Console.WriteLine("Criador de Playlist!");
            Console.WriteLine("Escolha - [1]Criar uma Playlist [2]Inserir Música [3]Listar Músicas [4] Alterar Playlist [5]Sair");
            value = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(value){
                case 1:
                    Console.WriteLine("Crie um Nome para a Playlist: ");
                    name = Console.ReadLine();
                    p.SetName(name);
                    Console.WriteLine("Descrição da Playlist: ");
                    description = Console.ReadLine();
                    p.SetDescription(description);
                    break;
                case 2:
                    Console.WriteLine("Nome da Música: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Nome do Artista: ");
                    artist = Console.ReadLine();
                    Console.WriteLine("Nome do Album: ");
                    album = Console.ReadLine();
                    Song m = new Song(name, artist, album);
                    p.InsertSong(m);
                    break;
                case 3:
                    Console.WriteLine("----- Playlist -----");
                    Console.WriteLine($"Nome: {p.GetName()} \nDescrição: {p.GetDescription()} \n");
                    Console.WriteLine("Músicas: ");
                    foreach(Song i in p.ListSong()) Console.WriteLine(i.ToString());
                    break;
                case 4:
                    Console.WriteLine("Informe um novo Nome para a Playlist: ");
                    p.SetName(Console.ReadLine());
                    Console.WriteLine("Informe uma nova Descrição para a Playlist: ");
                    p.SetDescription(Console.ReadLine());
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Valor Inválido! \n");
                    break;
            }
        }while(value != 5);

        Console.Clear();
        Console.WriteLine("Fim do Algoritmo!");
    }
}