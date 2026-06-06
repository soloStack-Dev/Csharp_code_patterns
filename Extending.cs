using System;

interface IUndoable
{
    void Undo();
}

interface IRedoable
{
    void Redo();
}

class Input : IRedoable
{
    public void Redo()
    {
        Console.WriteLine("Redoing input...");
    }

    public void Undo()
    {
        Console.WriteLine("Undoing input...");
    }
}