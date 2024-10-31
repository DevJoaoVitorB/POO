class Converter
{
    private int number;

    public Converter(){}

    public Converter(int n){
        if (n > 0) number = n;
    }

    public void SetNumber(int n){
        if (n > 0) number = n;
    }

    public int GetNumber(){
        return number;
    }

    public string ConvertBinary(){
        return Convert.ToString(number, 2);
    }

    public override string ToString(){
        return $"Número Inteiro = {number}";
    }
}