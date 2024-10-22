class Travel()
{
    // Armazenamento de Atributos
    public int km = 0, hours = 0, minutes = 0;

    // Metodos
    public int CalcVelocity(){
        return km / (hours + (minutes / 60));
    }
}