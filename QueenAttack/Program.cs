using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Give me the X coordinate of your Queen");
        int queenX = int.Parse(Console.ReadLine());
        Console.WriteLine("Give me the Y coordinate of your Queen");
        int queenY = int.Parse(Console.ReadLine());
        Queen myQueen = new Queen(queenX, queenY);
        Console.WriteLine("Your Queen is at position " + queenX + "," + queenY);
        Console.WriteLine("Give me the X coordinate of the piece you wish to attack");
        int newX = int.Parse(Console.ReadLine());
        Console.WriteLine("Give me the Y coordinate of the piece you wish to attack.");
        int newY = int.Parse(Console.ReadLine());
        myQueen.Move(newX, newY);

    }
}