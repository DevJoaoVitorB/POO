class Atleta
{
    private int id;
    private string nome;
    private DateTime nascimento = new DateTime();

    public Atleta(int id, string nome, DateTime nascimento){
        if(id >= 0) this.id = id;
        if(nome.Length > 0) this.nome = nome;
        if(nome.Length <= 0) throw new ArgumentException("Valor Inválido");
        this.nascimento = nascimento;
    }

    public override string ToString(){
        return $"ID: {id} - NOME: {nome} - DATA DE NASCIMENTO: {nascimento} \n";
    }
}

static class Atletas
{
    private static List<Atleta> objetos = new List<Atleta>();

    public static void Inserir(Atleta x){
        objetos.Add(x);
    }

    public static List<Atleta> Listar(){
        return objetos;
    }
}