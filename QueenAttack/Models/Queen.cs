using System;

public class Queen
{
    public int X;
    public int Y;

    public Queen(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool CanMove(int newX, int newY)
    {
        int deltaX = newX - X;
        int deltaY = newY - Y;
        if(((deltaX==0||deltaY==0)&&(deltaX!=0||deltaY!=0)||deltaY==deltaX|deltaY==0-deltaX))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Move(int newX, int newY)
    {
        if(CanMove(newX, newY))
        {
            Console.WriteLine("You can move to " + newX + "," + newY);
        }
        else
        {
            Console.WriteLine("This is not a legal move.");
        }

    }
}