public class Menu
{
    private Rectangle x = new Rectangle();
    private Delivery y = new Delivery();
    private Converter z = new Converter();
    private Equation w = new Equation();
    private Data a = new Data();
    private int value = 0;
    public void Choice(){
        do{
            Console.Write("Escolha a Questão [1]Q1 [2]Q2 [3]Q3 [4]Q4 [5]Q5 [6]Sair: ");
            value = int.Parse(Console.ReadLine());

            Console.Clear();

            switch(value)
            {
                case 1:
                    Console.WriteLine("Questão Número 1 da Lista03 - POO");
                    Console.Write("Informe o Valor da Base do Retângulo: ");
                    x.SetB(double.Parse(Console.ReadLine()));
                    Console.Write("Informe o Valor da Altura do Retângulo: ");
                    x.SetH(double.Parse(Console.ReadLine()));
                    Console.WriteLine(x.ToString());
                    Console.WriteLine($"A Diagonal do Retângulo é: {x.CalcDiagonal():f2} \n");
                    break;
                case 2:
                    Console.WriteLine("Questão Número 2 da Lista03 - POO");
                    Console.Write("Informe a Distância do Frete(km): ");
                    y.SetDistance(double.Parse(Console.ReadLine()));
                    Console.Write("Informe o Peso da Carga(kg): ");
                    y.SetWeight(double.Parse(Console.ReadLine()));
                    Console.WriteLine(y.ToString());
                    Console.WriteLine($"O Frete ficará por R${y.CalcDelivery():f2} \n");
                    break;
                case 3:
                    Console.WriteLine("Questão Número 3 da Lista03 - POO");
                    Console.Write("Informe o Valor Inteiro: ");
                    z.SetNumber(int.Parse(Console.ReadLine()));
                    Console.WriteLine(z.ToString());
                    Console.WriteLine($"Número Binário: {z.ConvertBinary()} \n");
                    break;
                case 4:
                    Console.WriteLine("Questão Número 4 da Lista03 - POO");
                    Console.WriteLine("Informe o Valor de a, b, c: ");
                    w.SetA(int.Parse(Console.ReadLine()));
                    w.SetB(int.Parse(Console.ReadLine()));
                    w.SetC(int.Parse(Console.ReadLine()));
                    Console.WriteLine(w.ToString());
                    Console.WriteLine($"Valor do Delta da Equação: {w.Delta():f2} \nValor da Raíz1: {w.Root1():f2} \nValor da Raíz2: {w.Root2():f2} \nApresenta Raíz Real: {w.RealRoot()} \n");
                    break;
                case 5:
                    Console.WriteLine("Questão Número 5 da Lista03 - POO");
                    Console.Write("Informe o Valor a Data no Padrão dd/mm/aaaa: ");
                    a.SetData(Console.ReadLine());
                    Console.WriteLine($"{a.ToString()} \n");
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Valor Inválido! \n");
                    break;
            }
        }while(value != 6);

        Console.Clear();
        Console.WriteLine("Finalização do Algoritimo");
    }
}