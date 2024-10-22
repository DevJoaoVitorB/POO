class Cine
{
    // Armazenamento de Atributos
    public string day = "";
    public int hours = 0;

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