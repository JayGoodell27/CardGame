
class Numbers
{
    int TotalScore = 300;
    
    public int AddPoints()
    {
       int score = TotalScore + 100;
       return score;

    }

    public int LosePoints()
    {
        
        int score = TotalScore - 75;
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
    public String DisplayPoints()
    {
        return($"Your score is: {TotalScore}");
    }
}
