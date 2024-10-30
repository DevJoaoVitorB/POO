class Cine
{
    // Propriedades/Variaveis
    private string day;
    private int hours;
    private string[] days = {"Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sabado", "Domingo"};

    // Construtor
        // Construtor Vazio! - Não está inicializando nenhuma Propriedade.
    public Cine(){}
        // Construtor que está inicializando as Propriedades da Classe.
    public Cine(string day, int hours){
        if (days.Contains(day)) this.day = day;
        if (hours > 0 && hours <= 24) this.hours = hours;
    }

    // Encapsulamento
    public void SetDay(string day){
        if (days.Contains(day)) this.day = day;
    }
    public void SetHours(int hours){
        if (hours > 0 && hours <= 24) this.hours = hours;
    }

    public string GetDay(){
        return day;
    }
    public int GetHours(){
        return hours;
    }

    // Metodos
    public double Entrace(){
        string[] day_week = {"Segunda-Feira", "Terça-Feira", "Quinta-Feira"};
        string[] day_weekend = {"Sexta-Feira", "Sabado", "Domingo"};

        if (day != "Quarta-Feira"){
            if (hours >= 17 && hours <= 24){
                if (day_week.Contains(day)){
                    return 24;
                }
                else if (day_weekend.Contains(day)){
                    return 30;
                }
            }
            else{
                if (day_week.Contains(day)){
                    return 16;
                }
                else if (day_weekend.Contains(day)){
                    return 20;
                }
            }
        }
        else{
            return 8;
        }

        return 0;
    }
}