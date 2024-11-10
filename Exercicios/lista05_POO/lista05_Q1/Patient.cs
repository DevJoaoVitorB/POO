class Patient
{
   private string name, CPF, phone;
   private DateTime birth = new DateTime();

   public Patient(){}
   public Patient(string name, string CPF, string phone, DateTime birth){
    if (name.Length > 0) this.name = name;
    if (CPF.Length == 14) this.CPF = CPF;
    if (phone.Length == 11) this.phone = phone; 
    if (name.Length <= 0 || CPF.Length != 14 || phone.Length != 11) throw new ArgumentOutOfRangeException("Valor(es) Inválido(s)!");
    this.birth = birth;
   }

   public string Year(){
      DateTime now = DateTime.Today;
      if ((now.Month == birth.Month && now.Day > birth.Day) || now.Month > birth.Month){
         return $"{(now.Year - birth.Year) - 1} anos";
      }

      return $"{now.Year - birth.Year} anos e {now.Month - birth.Month} meses";
   }

   public override string ToString(){
    return $"----- Paciênte ----- \nNome: {name} \nCPF: {CPF} \nTelefone: {phone} \nNascimento: {birth.Day:d2}/{birth.Month:d2}/{birth.Year} \n";
   }
}