FigureUI.MainUI();

static class FigureUI
{
    public static void MainUI()
    {
        int value = 0;
        do {
            try
            {
                value = Menu();
                Console.Clear();

                switch(value)
                {
                    case 0:
                        break;
                    case 1:
                        CalcVolume();
                        break;
                    default:
                        Console.WriteLine("Valor Informado Inválido!");
                        break;
                }        
            } catch {
               Console.WriteLine("ERROR! - Informe Valores Validos!");
            }
        } while(value != 0);
    }

    public static int Menu()
    {
        Console.WriteLine("\n----- Calculadora de Volume de Figuras 3D -----");
        Console.WriteLine("Informe - [1]Entra [0]Sair");
        return int.Parse(Console.ReadLine());
    }

    public static void CalcVolume()
    {
        try
        {
            double radius, side;

            Console.WriteLine("Volume de um Esfera!");
            Console.Write("Informe o Valor do Raio da Esfera: ");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("\nVolume de um Cubo!");
            Console.Write("Informe o Valor do Lado do Cubo: ");
            side = double.Parse(Console.ReadLine());

            Sphere x = View.GetSphere(radius);
            Cube y = View.GetCube(side);

            Console.WriteLine("\nVolume da Esfera e do Cubo!");
            Console.WriteLine($"{x}");
            Console.WriteLine($"{y}");

        } catch (Exception e) when (e is ArgumentException) {
            Console.WriteLine("ERROR! - Informe Valores Validos para os Campos!");
        } catch {
            Console.WriteLine("ERROR! - Valores Informados Inválidos!");
        }
    }
}