class Account
{
    // Propriedades/Variaveis
    private string name;
    private int number;
    private double value, WH, WD;

    // Construtores
        // Construtor Vazio! - Não está inicializando nenhuma Propriedade.
    public Account(){}
        // Construtor que está inicializando as Propriedades da Classe.
    public Account(string name, int number, double value, double WH, double WD){
        if (name.Length > 0) this.name = name;
        if (number >= 100 && number <= 999) this.number = number;
        if (value >= 0) this.value = value;
        if (WH > 0) this.WH = WH;
        if (WD > 0) this.WD = WD;
    }

    // Encapsulamento
    public void SetName(string name){
        if (name.Length > 0) this.name = name;
    }
    public void SetNumber(int number){
        if (number >= 100 && number <= 999) this.number = number;
    }
    public void SetValue(double value){
        if (value >= 0) this.value = value;
    }
    public void SetWH(double WH){
        if (WH > 0) this.WH = WH;
    }
    public void SetWD(double WD){
        if (WD > 0) this.WD = WD;
    }

    public string GetName(){
        return name;
    }
    public int GetNumber(){
        return number;
    }
    public double GetValue(){
        return value;
    }
    public double GetWH(){
        return WH;
    }
    public double GetWD(){
        return WD;
    }

    // Metodos
    public double CalcWareHouse(){
        return value + WH;
    }
    public double CalcWithDrawal(){
        return value - WD;
    }
}