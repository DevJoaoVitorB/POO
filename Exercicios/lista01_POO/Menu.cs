public class Menu
{   
    public void Choice(){
        Circle x = new Circle();
        Travel y = new Travel();
        Account z = new Account();
        Cine w = new Cine();
        int value = 0, n = 0;

        do{
            Console.Write("Escolha a Questão [1]Q1 [2]Q2 [3]Q3 [4]Q4 [5]Sair: ");
            value = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (value)
            {
                case 1:
                    Console.WriteLine("Questão Número 1 da Lista01 - POO");
                    Console.Write("Informe o Valor do Raio do Circulo: ");
                    x.SetRaio(int.Parse(Console.ReadLine()));
                    Console.WriteLine($"O Valor do Raio da Circuferência é: {x.GetRaio()}");
                    Console.WriteLine($"A Area do Circulo é: {x.CalcArea():f2}");
                    Console.WriteLine($"A Circunferência vale: {x.CalcCircumference():f2} \n");
                    break;
                case 2:
                    Console.WriteLine("Questão Número 2 da Lista01 - POO");
                    Console.Write("Informe a Distancia em Quilometros da Viagem: ");
                    y.SetKm(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Informe as Horas e Minutos da Viagem: ");
                    y.SetHours(int.Parse(Console.ReadLine()));
                    y.SetMinutes(int.Parse(Console.ReadLine()));
                    Console.WriteLine($"A Viagem de {y.GetKm()}km foi Realizada em {y.GetHours():d2}:{y.GetMinutes():d2}");
                    Console.WriteLine($"A Velocidade Media da Viagem foi: {y.CalcVelocity()}km/h \n");
                    break;
                case 3:
                    Console.WriteLine("Questão Número 3 da Lista01 - POO");
                    Console.Write("Informe o Nome do Titular da Conta: ");
                    z.SetName(Console.ReadLine());
                    Console.Write("Informe o Número da Conta: ");
                    z.SetNumber(int.Parse(Console.ReadLine()));
                    Console.Write("Informe o Último Saldo da Conta: R$");
                    z.SetValue(double.Parse(Console.ReadLine()));
                    Console.Write("Digite 1 para Depósito e 2 para Saque: ");
                    n = int.Parse(Console.ReadLine());
                    if (n == 1){
                        Console.Write("Informe o Valor do Depósito: R$");
                        z.SetWH(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"\nO Deposito de R${z.GetWH():f2} foi Realizado! \n");
                        Console.WriteLine($"---Extrato Bancário--- \n Titular: {z.GetName()} \n Número da Conta: {z.GetNumber()} \n Valor Antigo: {z.GetValue():f2} \n Valor Atual: {z.CalcWareHouse():f2} \n");
                    }
                    else if (n == 2){
                        Console.Write("Informe o Valor do Saque: R$");
                        z.SetWD(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"\nO Saque de R${z.GetWD():f2} foi Realizado! \n");
                        Console.WriteLine($"---Extrato Bancário--- \n Titular: {z.GetName()} \n Número da Conta: {z.GetNumber()} \n Valor Antigo: {z.GetValue():f2} \n Valor Atual: {z.CalcWithDrawal():f2} \n");
                    }
                    break;
                case 4:
                    Console.WriteLine("Questão Número 4 da Lista01 - POO");
                    Console.Write("Informe o Dia da Sessão de Cinema OBS.: O Valor Digitado deve estar Capitalizado (Sexta-Feira): ");
                    w.SetDay(Console.ReadLine());
                    Console.Write("Informe o Horário da Sessão de Cinema OBS.: O Valor Digitado deve ser apenas o Horário Arredondado (17): ");
                    w.SetHours(int.Parse(Console.ReadLine()));
                    Console.WriteLine($"- Dia: {w.GetDay()} \n- Horário: {w.GetHours()}:00 \nValor da Entrada: R${w.Entrace():f2} \n");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Valor Inválido! \n");
                    break;
            }
        }while(value != 5);

        Console.Clear();
        Console.WriteLine("Finalização do Algoritmo!");
    }
}