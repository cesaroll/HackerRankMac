using System;

class Solution
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var logic = new PointsLogic(n);

        //Read Coordinates
        for(int i=0; i<n; i++)
        {
            var input = Console.ReadLine().Split(' ');
            logic.AddPoint(i, int.Parse(input[0]), int.Parse(input[1]) );
        }

        n = int.Parse(Console.ReadLine());

        //Read Operations
        for(int i=0; i <n; i++)
        {
            var input = Console.ReadLine().Split(' ');
            logic.Operation(input[0], int.Parse(input[1]), int.Parse(input[2]));
        }

    }

}

public class PointsLogic
{
    private const string OpX = "X";
    private const string OpY = "Y";
    private const string OpC = "C";

    private const int Buckets = 4;
    private int[,] Points;

    public PointsLogic(int n)
    {
        Points = new int[n,2];
    }

    private int GetBucket(int idx)
    {
        return idx % Buckets;
    }

    public void AddPoint(int i, int x, int y)
    {
        Points[i,0] = x;
        Points[i,1] = y;
    }

    public void Operation(string op, int init, int end)
    {
        init--;
        end--;

        if(op == OpC)
        {
            Count(init, end);
        }
        else
        {
            if(op == OpX)
                Reflect(1,init, end);
            else if(op == OpY)
                Reflect(0,init, end);
        }
            
    }

    private void Count(int init, int end)
    {
        var quadrants = new int[4];

        for(int i=init; i<=end; i++)
        {
            quadrants[GetQuadrant(i)]++;
        }

        for(int i=0; i<4; i++)
        {
            Console.Write(quadrants[i] + " ");
        }

        Console.WriteLine();

    }

    private void Reflect(int p, int init, int end)
    {
        for(int i=init; i<=end; i++)
        {
            Points[i,p] *= -1;
        }

    }

    private int GetQuadrant(int idx)
    {   
        int X = Points[idx,0];
        int Y = Points[idx,1];

        if(X>0)
        {
            if(Y>0)
                return 0;
            else
                return 3;
        }
        else
        {
            if(Y>0)
                return 1;
            else
                return 2;
        }

    }

}