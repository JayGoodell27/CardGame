

//Console.Write($"The card is: {NewNum}");
//Console.
//vavarNumbers test = Numbersnew NumbersNn();:
//Numbers test = new Numbers();
//String Display = test.DisplayPoints();
//Cards randomtest = new Cards();
//int randomnumber = randomtest.NewNum();
//Console.WriteLine(randomnumber);
//Console.WriteLine(Display);

GameSystem run = new GameSystem();
run.Main();



class GameSystem
{
    public void Main()
    {   
        int TotalScore = 300;
        bool turnout = GameRun(TotalScore);
        while (turnout == true)
        {
        GameRun(TotalScore);
        }


        
    }






    public bool GameRun(int TotalScore)
    {
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
    // TotalScore = PointChange(outcome, TotalScore);
    
    // String display = score.DisplayPoints();
    // Console.Write($"{display}");

    String display = score.DisplayPoints(TotalScore);
    Console.WriteLine($"{display}");
    
    
    Console.Write($"Play again? [y/n] ");
    string? again = Console.ReadLine();
    if (again == "y")
    {
        return true;
    }
    else if (again =="n")
    {
        return false;
    }
    else 
    {
        return true;
    }
    


    }
    public bool Compare(int Card1, int Card2, string guess)
    {
    // bool result = true;
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
    public int PointChange(bool outcome, int TotalScore)
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


// class newGame
// {
//     public string 
// }





// class GameSystem



// {
//     public void Main()
//     {
//     Cards newCard = new Cards();
//     Numbers score = new Numbers();
//     Console.WriteLine($"The card is :{newCard}");
    
    
//     Console.Write("Higher or lower? [h/l] ");

//     string? guess = Console.ReadLine();
    
//     Console.Write($"Next card was: {newCard}");
    
    
//     String display = score.DisplayPoints();
//     Console.Write($"{display}");
    
//     //Console.Write("Your score is: {}");
//     Console.Write($"Play again? [y/n] ");
//     string? again = Console.ReadLine();

//     }
// }

// GameSystem run = new GameSystem();
// run.Main();