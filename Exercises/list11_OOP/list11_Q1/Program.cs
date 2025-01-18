CalcUI.MainUI();

static class CalcUI
{
    public static void MainUI()
    {
        int value = 0;
        do{
            try
            {
                value = Menu();
                Console.Clear();

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

    public static int Menu()
    {
        Console.WriteLine("--- Calcular Área e Diagonal ---");
        Console.WriteLine("Informe [1]Entrar [0]Sair");
        return int.Parse(Console.ReadLine());
    }

    public static void CalcArea()
    {
        try
        {
            double b, h;
            Console.WriteLine("Valores dos Lados");
            Console.Write("BASE(b): ");
            b = double.Parse(Console.ReadLine());
            Console.Write("ALTURA(h): ");
            h = double.Parse(Console.ReadLine());

            object x = View.Verification(b, h);

            Console.WriteLine($"{x} \n");

        } catch (Exception e) when (e is ArgumentException){
            Console.WriteLine("\nOs Valores de Base e Altura não podem ser iguais a 0! \n");
        } catch {
            Console.WriteLine("\nOs Valores de Base e Altura devem ser Numerais e não Vazios! \n");
        }
    }
}