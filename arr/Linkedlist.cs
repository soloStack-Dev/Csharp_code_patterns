namespace arr
{
    public class LinkedList
    {
        static void Main()
        {
            LinkedList<int> list = new();
            list.AddLast(10);
            list.AddFirst(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            LinkedListNode<int>? findInteger = list.Find(10);
            list.AddAfter(findInteger ?? list.First!, 15);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
        }
    }
}