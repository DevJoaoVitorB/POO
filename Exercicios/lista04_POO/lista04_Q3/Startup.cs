class Enterprise
{
    private string name;
    private List<Client> Clients = new List<Client>();

    public Enterprise(){}
    public Enterprise(string name){
        if (name.Length >= 2) this.name = name;
        if (name.Length < 2) throw new ArgumentException("Valor Inválido");
    }

    public void Insert(Client c){
        Clients.Add(c);
    }

    public List<Client> List(){
        return Clients;
    }

    public override string ToString(){
        return $"A Empresa {name} possui {Clients.Count()} Cliente(s)! \n";
    }
}

class Client
{
    private string name, CPF;
    private double limit, limitSolo;
    private Client associate = null;

    public Client(){}
    public Client(string name, string CPF, double limit){
        if(name.Length >= 1) this.name = name;
        if(CPF.Length == 14) this.CPF = CPF;
        if(limit >= 0) this.limit = limit;
        if(name.Length < 1 || CPF.Length != 14 || limit < 0) throw new ArgumentException("Valor(es) Inválido(s)");
        limitSolo = limit;
    }

    public void SetAssociate(Client c){
        if (c.GetCPF() == CPF) throw new ArgumentException($"O Client {name} não pode ser Sócio dele mesmo!");
        if (associate == null){
            associate = c;
            limit += associate.GetLimit();
            associate.SetLimitAssociate(limitSolo);
        }
        if (associate != null){
            limit = limitSolo;
            associate.SetLimitDissociation(limitSolo);
            associate = c;
            limit += associate.GetLimit();
            associate.SetLimitAssociate(limitSolo);
        }
    }

    public void SetLimitAssociate(double limitAssociate){
        limit += limitAssociate;
    }

    public void SetLimitDissociation(double limitAssociate){
        associate = null;
        limit -= limitAssociate;
    }

    public double GetLimit(){
        return limit;
    }

    public string GetName(){
        return name;
    }
    public string GetCPF(){
        return CPF;
    }

    public override string ToString(){
        if (associate == null){
            return $"--- Cliente --- \nNome: {name} \nCPF: {CPF} \nLimite de Crédito(Individual): R${limitSolo:f2} \nLimite de Crédito(Total): R${limit:f2} \nSócio: {associate} \n";
        }
        else{
            return $"--- Cliente --- \nNome: {name} \nCPF: {CPF} \nLimite de Crédito(Individual): R${limitSolo:f2} \nLimite de Crédito(Total): R${limit:f2} \nSócio: {associate.GetName()} \n";
        }
    }
}