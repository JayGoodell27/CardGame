
class Numbers
{
    
    
    public int AddPoints(int TotalScore)
    {
       int score = TotalScore + 100;
       return score;

    }

    public int LosePoints(int TotalScore)
    {
        
        int score = TotalScore - 75;
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
    {
        return($"Your score is: {TotalScore}");
    }
    
}
