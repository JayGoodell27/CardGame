
//Class that handles the number generation and some of the points process
class Numbers
{
    // int TotalScore = 300;
    
    
    public int AddPoints(int TotalScore)
    {
       int score = TotalScore + 100;
       TotalScore = score;
       return score;

    }

    public int LosePoints(int TotalScore)
    {
        
        int score = TotalScore - 75;
        TotalScore = score;
        return score;
    }

    public bool GameOverCheck(int TotalScore)
    {
        if (TotalScore <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public string DisplayPoints(int TotalScore)
    {return($"Your score is: {TotalScore}");}
    
}
