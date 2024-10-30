class Travel
{
    // Propriedades/Variaveis
    private int km, hours, minutes;

    // Construtor
        // Construtor Vazio! - Não está inicializando nenhuma Propriedade.
    public Travel(){}
        // Construtor que está inicializando as Propriedades da Classe.
    public Travel(int km, int hours, int minutes){
        if (km > 0) this.km = km;
        if (hours > 0) this.hours = hours;
        if (minutes > 0) this.minutes = minutes;
    }

    // Encapsulamento
    public void SetKm(int km){
        if (km > 0) this.km = km;
    }
    public void SetHours(int hours){
        if (hours > 0) this.hours = hours;
    }
    public void SetMinutes(int minutes){
        if (minutes > 0) this.minutes = minutes;
    }

    public int GetKm(){
        return km;
    }
    public int GetHours(){
        return hours;
    }
    public int GetMinutes(){
        return minutes;
    }

    // Metodos
    public int CalcVelocity(){
        return km / (hours + (minutes / 60));
    }
}