
class Numbers
{
    int TotalScore = 300;
    
    
    public int AddPoints()
    {
       int score = TotalScore + 100;
       TotalScore = score;
       return score;

    }

    public int LosePoints()
    {
        
        int score = TotalScore - 75;
        TotalScore = score;
        return score;
    }

    public bool GameOverCheck()
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
    public string DisplayPoints()
    {
        return($"Your score is: {TotalScore}");
    }
    
}
