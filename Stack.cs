using System;

class Stack<T>
{
    //current value is negative value
    int current = -1;
    //mention the generic type it handle any datatypes of arrays
    T[] items;

    //create the constructor to set the size of an arrays for adding n of items 
    public Stack(int size)
    {
        items = new T[size];
    }

    //check if the stack is empty
    //if the current value is negative value then the stack is empty
    public bool Empty => current == -1;
    //check if the stack is full
    //if the current value is equal to the size of the arrays minus 1 then the stack is full
    public bool Full => current == items.Length - 1;

    //if we add new items to the stack then the current value will be incremented
    public bool Push(T item)
    {
        if (!Full)
        {
            items[++current] = item;
            return true;
        }
        return false;
    }
    //if we remove items from the stack then the current value will be decremented
    public T? Pop() => !Empty ? items[current--] : default(T);

}