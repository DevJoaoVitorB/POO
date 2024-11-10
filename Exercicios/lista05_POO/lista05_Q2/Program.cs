Menu.Choice();

static class Menu{
    private static int value;
    private static decimal valueBill, valuePay;
    private static string code;
    private static Bill bill = new Bill();
    private static Random random = new Random();

    public static void Choice(){
        do{
            Console.WriteLine("Emissão e Pagemento de Boleto!")
            Console.WriteLine("Escolha - [1]Emitir Boleto [2]Pagar Boleto [3]Verificar Boleto [4]Sair")
            value = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(value){
                case 1:
                    Console.WriteLine("Informe o Valor do Boleto: ");
                    valueBill = decimal.Parse(Console.ReadLine());
                    code = string.Parse(random.Next(13294850383, 99999999999));
                    DateTime emission = DateTime.Today();
                    DateTime payDay = emission.AddMonths(1);
                    bill = new Bill(code, emission, payDay, valueBill);
                    break;
                case 2:
                    Console.WriteLine($"{bill.ToString()}");
                    Console.WriteLine("\nInforme o Valor a ser Pago: R$");
                    valuePay = decimal.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine($"{bill.ToString()}");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Valor Inválido! \n");
                    break;
            }       
        }while(value != 4);
    }
}
