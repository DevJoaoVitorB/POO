class Treino
{
    private int id;
    private int idAtleta;
    private DateTime data = new DateTime();
    private int distancia;
    private TimeSpan tempo = new TimeSpan();

    public Treino(int id, int idAtleta, int distancia, DataTime data, TimeSpan tempo){
        if(id >= 0) this.id = id;
        if(idAtleta >= 0) this.idAtleta = idAtleta;
        if(distancia >= 0) this.distancia = distancia;
        if(distancia < 0) throw new ArgumentException("Valor Inválido!");
        this.data = data;
        this.tempo = tempo;
    }

    public double Pace(){
        double t = ((double)(tempo.Hours * 60)) + (double)tempo.Minutes + ((double)(tempo.Seconds/60));
        return (double)t/distancia;
    }

    public override string ToString(){
        return $"ID: {id} - ID DO ATLETA: {idAtleta} - DATA: {data} - DISTÂNCIA: {distancia} - TEMPO: {tempo} - PACE: {Pace():f2} \n";
    }
}

static class Treinos
{
    private static List<Treino> objetos = new List<Treino>();

    public static void Inserir(Treino x){
        objetos.Add(x);
    }

    public static List<Treino> Listar(){
        return objetos;
    }
}

