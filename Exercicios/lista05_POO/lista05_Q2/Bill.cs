class Bill
{
    private string code;
    private DateTime dateEmission = new DateTime();
    private DateTime datePay = new DateTime();
    private decimal valueBill, valuePay;
    private Pay paySituation = new Pay();

    public Bill(){}
    public Bill(string code, DateTime emission, DateTime Payday, decimal valueBill){
        if (code.Length >= 5) this.code = code;
        if (valueBill > 0) this.valueBill = valueBill;
        if (code.Length < 5 || valueBill <= 0) throw new ArgumentException("Valor(es) Inválido(s)!")
        dateEmission = emission;
        datePay = Payday;
    }

    public void Pay(decimal valuePay){
        valueBill -= valuePay;
    }

    public Pay SituationBill(){
        return paySituation;
    }

    public override string ToString(){
        return $"Boleto: \nCódigo de Barra: {code} \nData de Emissão: {dateEmission} \nVencimento: {datePay} \nValor da Fatura: {valueBill:f2} \nValor Pago: {valuePay:f2} \nSituação do Boleto: {paySituation} \n";
    }
}

class Pay
{
    private int open, partialPay, pay;
    public enum Situation{
                   
    }
}