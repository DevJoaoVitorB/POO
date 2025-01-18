DeliveryUI.MainUI();

static class DeliveryUI
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
                        CalcDelivery();
                        break;
                    default:
                        Console.WriteLine("Valor Informado está Inválido!");
                        break;
                }
            } catch {
                Console.WriteLine("ERROR! - Informe um Valor Númerico!");
            }
        } while (value != 0);
    }

    public static int Menu()
    {
        Console.WriteLine("----- Calculadora de Frete -----");
        Console.WriteLine("Informe - [1]Entrar [0]Sair");
        return int.Parse(Console.ReadLine());
    }

    public static void CalcDelivery()
    {
        try
        {
            double distance, weight;
            decimal insurance;

            Console.WriteLine("Informações de Carga");
            Console.Write("Distância a ser Percorrida(KM): ");
            distance = double.Parse(Console.ReadLine());
            Console.Write("Peso da Carga(KG): ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Informe o Valor do Seguro de Carga: R$");
            insurance = decimal.Parse(Console.ReadLine());

            object x = View.DeliveryCreate(distance, weight, 0);
            object y = View.DeliveryCreate(distance, weight, insurance);

            int value = 0;
            do {
                Console.WriteLine("\nESCOLHA O SEU FRETE!");
                Console.WriteLine($"{x} \n{y}\n");
                Console.WriteLine("Escolha - [1]Frete Básico [2] Frete Expresso [0]Sair");
                value = int.Parse(Console.ReadLine());
                Console.Clear();

                switch(value)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine($"Frete Básico sendo Processado...");
                        break;
                    case 2:
                        Console.WriteLine($"Frete Expresso sendo Processado...");
                        break;
                    default:
                        Console.WriteLine("Valor Informado está Inválido!");
                        break;
                }        
            } while(value != 0 && value != 1 && value != 2);

        } catch (Exception e) when (e is ArgumentException) {
            Console.WriteLine($"ERROR! - Valores Inseridos Incorretamnete!");
        } catch {
            Console.WriteLine($"ERROR! - Preencha as Informações Corretamente!");
        }

    }
}