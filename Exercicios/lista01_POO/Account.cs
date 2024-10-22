class Account
{
    // Armazenamento de Atributos
    public string name = "";
    public int number = 0;
    public double value = 0, WH = 0, WD = 0;

    // Metodos
    public double CalcWareHouse(){
        return value + WH;
    }

    public double CalcWithDrawal(){
        return value - WD;
    }
}