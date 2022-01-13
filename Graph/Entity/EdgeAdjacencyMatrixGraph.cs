﻿namespace Graph.Entity;

public class EdgeAdjacencyMatrixGraph : IMatrixGraph
{
    private readonly int _size;
    private readonly int _capacity;
    public int[,] Matrix { get; }
    public int Size { get; }
    public int Сapacity { get; }

    public EdgeAdjacencyMatrixGraph(int[,] matrix)
    {
        Matrix = matrix;
        _size = matrix.Length;
        _capacity = CalculateCapacity();
    }

    private int CalculateCapacity()
    {
        throw new NotImplementedException();
    }
}