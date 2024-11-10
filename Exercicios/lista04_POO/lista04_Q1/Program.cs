Menu.Choice();
static class Menu
{
    private static int value, balls, n;
    private static Bingo c = new Bingo();

    public static void Choice(){
        newgame:
        Console.Clear();
        Console.WriteLine("----- Bingo -----");
        Console.WriteLine("Informe a Quantidade de Bolas do Jogo: ");
        balls = int.Parse(Console.ReadLine());
        c = new Bingo(balls);
        do{
            Console.WriteLine("\nEscolha - Novo Jogo[1] Sortear[2] Sair[3]: ");
            value = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (value){
                case 1:
                    goto newgame;
                case 2:
                    n = c.Randomize();
                    if (n == -1){
                        Console.WriteLine("Bingo!");
                    } else {
                        Console.WriteLine($"A Bola Sorteada é: {n}");
                    }
                    Console.WriteLine($"Bolas Sorteadas: ");
                    foreach(int i in c.BallsWinners()) Console.Write($"{i} - ");
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Valor Inválido! \n");
                    break;
                
            }
        }while(value != 3);
        Console.Clear();
        Console.WriteLine("Fim de Jogo!");
    }
}