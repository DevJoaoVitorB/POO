CalcUI.MainUI();

static class CalcUI
{
    public static void MainUI(){
        int value = 0;

        do{
            try
            {
                value = Menu();

                switch(value)
                {
                    case 0:
                        break;
                    case 1:
                        CalcArea();
                        break;
                    default:
                        Console.WriteLine("Valor Inválido!");
                        break;
                }

            } catch {
                Console.WriteLine("Valor Inválido!");
            }

        } while(value != 0);
    }

    public static int Menu(){
        Console.WriteLine("--- Calcular Área e Diagonal ---");
        Console.WriteLine("Informe [1]Entrar [0]Sair");
        return int.Parse(Console.ReadLine());
    } 
}