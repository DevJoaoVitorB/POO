using System;

class Program
{
    static void Main()
    {
        Circle x = new Circle();
        Travel y = new Travel();
        Account z = new Account();
        Cine w = new Cine();
        int n = 0;

        Console.WriteLine("Questão Número 1 da Lista01 - POO");
        Console.Write("Informe o Valor do Raio do Circulo: ");
        x.r = int.Parse(Console.ReadLine());
        Console.WriteLine($"A Area do Circulo é: {x.CalcArea():f2}");
        Console.WriteLine(" ");

        Console.WriteLine("Questão Número 2 da Lista01 - POO");
        Console.Write("Informe a Distancia em Quilometros da Viagem: ");
        y.km = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe as Horas e Minutos da Viagem: ");
        y.hours = int.Parse(Console.ReadLine());
        y.minutes = int.Parse(Console.ReadLine());
        Console.WriteLine($"A Velocidade Media da Viagem é: {y.CalcVelocity()}km/h");
        Console.WriteLine(" ");

        Console.WriteLine("Questão Número 3 da Lista01 - POO");
        Console.Write("Informe o Nome do Titular da Conta: ");
        z.name = Console.ReadLine();
        Console.Write("Informe o Número da Conta: ");
        z.number = int.Parse(Console.ReadLine());
        Console.Write("Informe o Último Saldo da Conta: R$");
        z.value = double.Parse(Console.ReadLine());
        Console.Write("Digite 1 para Depósito e 2 para Saque: ");
        n = int.Parse(Console.ReadLine());
        if (n == 1){
            Console.Write("Informe o Valor do Depósito: R$");
            z.WH = double.Parse(Console.ReadLine());
            Console.WriteLine($"O Deposito de R${z.WH:f2} foi Realizado!");
            Console.WriteLine($"---Extrato Bancário--- \n Titular: {z.name} \n Número da Conta: {z.number} \n Valor Antigo: {z.value:f2} \n Valor Atual: {z.CalcWareHouse():f2}");
            Console.WriteLine(" ");
        }
        else if (n == 2){
            Console.Write("Informe o Valor do Saque: R$");
            z.WD = double.Parse(Console.ReadLine());
            Console.WriteLine($"O Saque de R${z.WD:f2} foi Realizado!");
            Console.WriteLine($"---Extrato Bancário--- \n Titular: {z.name} \n Número da Conta: {z.number} \n Valor Antigo: {z.value:f2} \n Valor Atual: {z.CalcWithDrawal():f2}");
            Console.WriteLine(" ");
        }

        Console.WriteLine("Questão Número 4 da Lista01 - POO");
        Console.Write("Informe o Dia da Sessão de Cinema OBS.: O Valor Digitado deve estar Capitalizado (Sexta-Feira): ");
        w.day = Console.ReadLine();
        Console.Write("Informe o Horário da Sessão de Cinema OBS.: O Valor Digitado deve ser apenas o Horário Arredondado (17): ");
        w.hours = int.Parse(Console.ReadLine());
        Console.WriteLine($"O Valor da Entrada será de: R${w.Entrace():f2}");
        Console.WriteLine(" ");
    }
}