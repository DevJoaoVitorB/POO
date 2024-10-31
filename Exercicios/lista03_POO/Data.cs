class Data
{
    private int day, month, year;
    private int[] month31 = {1, 3, 5, 7, 8, 10, 12};
    private int[] month30 = {4, 6, 9, 11};

    public Data(){}

    public Data(string data){
        data.Split('/');
        day = int.Parse(data[0]);
        mouth = int.Parse(data[1]);
        year = int.Parse(data[2]);

        if (month <= 0 && month > 12) month = 0;
        if ((not(month31.Content(month)) && day <= 0 && day > 31) || (not(mouth30.Content(month)) && day <= 0 && day > 30) || (mouth != 29 && day <= 0 && day > 29)){
            day = 0;
            year = 0;
        }
    }
    public void SetData(string data){
        data.Split('/');
        day = int.Parse(data[0]);
        mouth = int.Parse(data[1]);
        year = int.Parse(data[2]);

        if (month <= 0 && month > 12) month = 0;
        if ((not(month31.Content(month)) && day <= 0 && day > 31) || (not(mouth30.Content(month)) && day <= 0 && day > 30) || (mouth != 29 && day <= 0 && day > 29)) {
            day = 0;
            year = 0;
        }
    }

    public int GetDay(){
        return $"{day:d2}";
    }
    public int GetMonth(){
        return $"{month:d2}";
    }
    public int GetYear(){
        return $"{year:d4}";
    }

    public override string ToString(){
        return $"Data: {day:d2}/{month:d2}/{year:d4}";
    }
}