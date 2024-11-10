Register.RegisterPatient();

static class Register
{
    private static string name, CPF, phone;
    private static int value;
    private static Patient patient = new Patient();
    private static DateTime birth = new DateTime();

    public static void RegisterPatient(){
        do{
            Console.WriteLine("----- Registro de Paciênte -----");
            Console.WriteLine("Escolha - [1]Resgistrar [2]Ver Idade [3]Informações do Paciênte [4]Sair");
            value = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (value){
                case 1:
                    Console.WriteLine("Informe o Nome do Paciênte: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Informe o CPF do Paciênte (Padrão: XXX.XXX.XXX-XX): ");
                    CPF = Console.ReadLine();
                    Console.WriteLine("Informe o Telefone do Paciênte (Padrão: XXXXXXXXXXX): ");
                    phone = Console.ReadLine();
                    Console.WriteLine("Informe a Data de Nascimento do Paciênte (Padrão: XX(MÊS)/XX(DIA)/XXXX(ANO)): ");
                    birth = DateTime.Parse(Console.ReadLine());
                    patient = new Patient(name, CPF, phone, birth);
                    break;
                case 2:
                    Console.WriteLine($"O Paciente possui: {patient.Year()}");
                    break;
                case 3:
                    Console.WriteLine($"{patient.ToString()}");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Valor Inválido! \n");
                    break;
            }

        }while(value != 4);

        Console.Clear();
        Console.WriteLine("Fim do Algoritimo!");
    }
}