class Circle
{
    // Propriedades/Variaveis
    private int r;

    // Construtor
        // Construtor Vazio! - Não está inicializando nenhuma Propriedade.
    public Circle(){}
        // Construtor que está inicializando as Propriedades da Classe. 
    public Circle(int r){
        if (r > 0) this.r = r;
    }

    // Encapsulamento
    public void SetRaio(int r){
        if (r > 0) this.r = r;
    }
    public int GetRaio(){
        return r;
    }

    // Metodos
    public double CalcArea(){
        return Math.PI * Math.Pow(r, 2);
    }
    public double CalcCircumference(){
        return Math.PI * 2 * r;
    }
}