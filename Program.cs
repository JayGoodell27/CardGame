GameSystem run = new GameSystem();
run.Main();



class GameSystem
{
    public void Main()
    {   
        bool ReRun = true;
        int TotalScore = 300;
        while (ReRun == true)
            {
            Tuple<bool, int> turnout = (GameRun(TotalScore));
            bool IsTrue = turnout.Item1;
            int Point = turnout.Item2;
            ReRun = IsTrue;
            TotalScore = Point;
            if (TotalScore <= 0)
                {
                    Console.WriteLine("You Lost!");
                    ReRun = false;
                }
                
            }   
    }


    public static Tuple<bool, int> GameRun(int TotalScore)
    {
    bool ReturnAgain;
    int CurrentScore = TotalScore;
    Cards newCard = new Cards();
    Numbers score = new Numbers();
    int RandomCard1 = newCard.NewNum();
    int RandomCard2 = newCard.NewNum();
    Console.WriteLine($"Your current amount of points is {TotalScore}");
    Console.WriteLine($"The card is :{RandomCard1}");
    
    
    Console.Write("Higher or lower? [h/l] ");
    
    string? guess = Console.ReadLine();
    
    Console.WriteLine($" Next card was: {RandomCard2}");
    bool outcome = Compare(RandomCard1, RandomCard2, guess);
    TotalScore = PointChange(outcome, TotalScore);
    String display = score.DisplayPoints(TotalScore);
    Console.Write($"{display}");
    Console.Write($"Play again? [y/n] ");
    string? again = Console.ReadLine();
    if (again == "y")
        {
            ReturnAgain = true;
        }
    else if (again =="n")
        {
            ReturnAgain = false;
        }
    else 
        {
            ReturnAgain = true;
        }
    return Tuple.Create(ReturnAgain, TotalScore);
    
    


    }
    public static bool Compare(int Card1, int Card2, string guess)
    {
        if (Card2 >= Card1 && guess == "h")
            {
            return true;
            }
        else if (Card1 > Card2 && guess == "l")
            {
            return true;
            }
        else
            {
            return false;
            }

    }
    public static int PointChange(bool outcome, int TotalScore)
    {
    Numbers score = new Numbers();
    if (outcome == true)
        {
        TotalScore = score.AddPoints(TotalScore);
        return TotalScore;
        }
   else
        {
        TotalScore = score.LosePoints(TotalScore);
        return TotalScore;
        }
    
    }
}