using System;

class MultiDimention
{
    public void Demo()
    {
        Console.WriteLine("----2D Array----");
        int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine($"Matrix: [{matrix[0, 0]} {matrix[0, 1]} {matrix[0, 2]}]");
        Console.WriteLine($"Matrix: [{matrix[1, 0]} {matrix[1, 1]} {matrix[1, 2]}]");
        Console.WriteLine($"Matrix: [{matrix[2, 0]} {matrix[2, 1]} {matrix[2, 2]}]");

        Console.WriteLine("----3D Array----");

        int[,,] tensor = new int[2,2,3] { 
            { { 1, 2, 3 }, { 4, 5, 6 } },
            { { 7, 8, 9 }, { 10, 11, 12 } } 
        };
        Console.WriteLine($"Tensor: [{tensor[0, 0, 0]} {tensor[0, 0, 1]} {tensor[0, 0, 2]}]");
        Console.WriteLine($"Tensor: [{tensor[0, 1, 0]} {tensor[0, 1, 1]} {tensor[0, 1, 2]}]");
        Console.WriteLine($"Tensor: [{tensor[1, 0, 0]} {tensor[1, 0, 1]} {tensor[1, 0, 2]}]");
        Console.WriteLine($"Tensor: [{tensor[1, 1, 0]} {tensor[1, 1, 1]} {tensor[1, 1, 2]}]");
    }
}