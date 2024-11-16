class Bill
{
    private string code;
    private DateTime dateEmission = new DateTime();
    private DateTime datePay = new DateTime();
    private decimal valueBill, valuePay, bill;
    private Pay paySituation = global::Pay.EmAberto;

    public Bill(){}
    public Bill(string code, DateTime emission, DateTime Payday, decimal valueBill){
        if (valueBill > 0) this.valueBill = valueBill;
        if (valueBill <= 0) throw new ArgumentException("Valor(es) Inválido(s)!");
        this.code = code;
        dateEmission = emission;
        datePay = Payday;
        bill = valueBill;
    }

    public void Pay(decimal valuePay){
        if (valuePay >= valueBill){
            valueBill = 0;
            this.valuePay = valueBill; 
            paySituation = global::Pay.Pago;
        } else if (valuePay < valueBill && valuePay != 0) {
            valueBill -= valuePay;
            this.valuePay = valuePay;
            paySituation = global::Pay.ParcialmentePago;
        } else {
            this.valuePay = valuePay;
            paySituation = global::Pay.EmAberto;
        }
    }

    public Pay SituationBill(){
        return paySituation;
    }

    public override string ToString(){
        return $"Boleto: \nData de Emissão: {dateEmission} \nVencimento: {datePay} \nValor da Fatura: R${bill:f2}\nValor a Ser Pago: R${valueBill:f2}\nValor Pago: R${valuePay:f2} \nSituação do Boleto: {paySituation} \nCódigo de Barra: {code} \n";
    }
}

enum Pay
{
    EmAberto, ParcialmentePago, Pago
}