class Bingo
{
    private int numBalls;
    private List<int> balls;
    
    public Bingo(){}
    public Bingo(int n)
    {
        if (n >= 1) numBalls = n;
        if (n < 1) throw new ArgumentOutOfRangeException("Número de Bolas Inválido!");
        balls = new List<int>();
    }

    public int Randomize(){
        if(balls.Count == numBalls) return -1;

        Random random = new Random();
        int number = random.Next(1, numBalls + 1);   

        while(balls.Contains(number)){
            number = new Random().Next(0, numBalls + 1); 
        }

        balls.Add(number);
        return number;
    }

    public List<int> BallsWinners(){
        return balls;
    }
}