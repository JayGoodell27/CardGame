class Cards {

    public int NewNum() 
    {
        Random rnd = new Random();
        int NewNum = rnd.Next(1,9);
        return NewNum;
    }

}