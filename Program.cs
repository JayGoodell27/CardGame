

//Console.Write($"The card is: {NewNum}");
//Console.
//vavarNumbers test = Numbersnew NumbersNn();:
//Numbers test = new Numbers();
//String Display = test.DisplayPoints();
//Cards randomtest = new Cards();
//int randomnumber = randomtest.NewNum();
//Console.WriteLine(randomnumber);
//Console.WriteLine(Display);



class GameSystem



{
    public void Main()
    {
    Cards newCard = new Cards();
    Numbers score = new Numbers();

    Console.WriteLine($"The card is :{newCard}");
    
    
    Console.Write("Higher or lower? [h/l] ");
    
    string? guess = Console.ReadLine();
    
    Console.Write($"Next card was: {newCard}");
    
    
    String display = score.DisplayPoints();
    Console.Write($"{display}");
    
    //Console.Write("Your score is: {}");
    Console.Write($"Play again? [y/n] ");
    string? again = Console.ReadLine();
    }
}