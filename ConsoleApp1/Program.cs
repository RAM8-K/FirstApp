using System;

class MainClass
{
    public static void Main(string[] args)
    {
        SemaPhore Favorite_Colour;
        Favorite_Colour = SemaPhore.green;
        Console.WriteLine(Favorite_Colour);
    }
}

enum SemaPhore
{ 
    red = 100,
    yellow = 200,
    green = 300
}