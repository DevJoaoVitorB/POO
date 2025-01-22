UI.MainUI();

static class UI
{
    private static int aux = 1, aux2 = 1;
    public static void MainUI(){
        int value = 0;
        while(value != 7){
            value = Menu();
            Console.Clear();

            switch(value){
                case 1:
                    AtletaInserir();
                    break;
                case 2:
                    AtletaListar();
                    break;
                case 3:
                    TreinoInserir();
                    break;
                case 4:
                    TreinoListar();
                    break;
                case 5:
                    AtletaMaisRapido();
                    break;
                case 6:
                    TreinoMaisRapido();
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Valor Inválido!");
                    break;
            }
        }
    }

    public static int Menu(){
        Console.WriteLine("[1]Inserir Atleta - [2]Listar Atletas - [3]Inserir Treino - [4]Listar Treinos - [5]Atleta + Rápido - [6]Treino + Rápido - [7]Sair \n");
        return int.Parse(Console.ReadLine());
    }

    public static void AtletaInserir(){
        Console.WriteLine("Informe o Nome do Atleta: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe a Data de Nascimento do Atleta(DIA): ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a Data de Nascimento do Atleta(MÊS): ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a Data de Nascimento do Atleta(ANO): ");
        int a = int.Parse(Console.ReadLine());
        DateTime nascimento = new DateTime(a, m, d);

        Atleta x = new Atleta(aux, nome, nascimento);
        aux += 1;

        Atletas.Inserir(x);
    }


    public static void AtletaListar(){
        if(Atletas.Listar().Count() == 0){
            Console.WriteLine("Nenhum Atleta Encontrado!");
        } else {
            foreach(Atleta i in Atletas.Listar()) Console.WriteLine($"{i}");
        }
    }

    public static void TreinoInserir(){
        AtletaListar();
        Console.WriteLine("Informe o ID do Atleta do Treino: ");
        int idAtleta = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a Data do Treino do Atleta(DIA): ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a Data de Treino do Atleta(MÊS): ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a Data de Treino do Atleta(ANO): ");
        int a = int.Parse(Console.ReadLine());
        DateTime data = new DateTime(a, m, d);

        Console.WriteLine("Informe a Distância do Treino do Atleta(KM): ");
        int distancia = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a Tempo do Treino do Atleta(HORAS): ");
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a Tempo do Treino do Atleta(MINUTOS): ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a Tempo do Treino do Atleta(SEGUNDOS): ");
        int s = int.Parse(Console.ReadLine());
        TimeSpan tempo = new TimeSpan(h, min, s);

        Treino x = new Treino(aux2, idAtleta, distancia, data, tempo);
        aux2 += 1;

        Treinos.Inserir(x);
    }

    public static void TreinoListar(){
        if(Treinos.Listar().Count() == 0){
            Console.WriteLine("Nenhum Treino Encontrado!");
        } else {
            foreach(Treino i in Treinos.Listar()) Console.WriteLine($"{i}");
        }
    }

    public static void AtletaMaisRapido(){
        List<Treino> treinos = Treinos.Listar();
        Treino menor = treinos[0];

        foreach(Treino i in Treinos.Listar()) if(i.Pace() < menor.Pace()) menor = i;

        Console.WriteLine($"Atleta Mais Rápido: {menor.GetIdAtleta()}");
    }

    public static void TreinoMaisRapido(){
        Console.WriteLine("Informe o ID do Atleta que Deseja Verificar o Treino Mais Rápido: ");
        int id = int.Parse(Console.ReadLine());
        Treino menor = new Treino();

        foreach(Treino i in Treinos.Listar()) if(i.GetIdAtleta() == id) menor = i;

        foreach(Treino i in Treinos.Listar()){
            if(i.GetIdAtleta() == id){
                if(i.Pace() < menor.Pace()) menor = i;
            }
        }

        Console.WriteLine($"Treino Mais Rápido: {menor}");
    }
}