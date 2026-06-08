namespace arr
{
    public class Span
    {
        static void Main()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Span");
            int[] nums = {10,20,30,40,50};
            Span<int> slice = nums.AsSpan(1, 3);
            slice[0] = 99;
            Console.WriteLine(slice[1]);
            foreach(int num in slice)
            {
                Console.WriteLine($"[{num}]");
            }
            Console.WriteLine("----------------------------------------------");
        }
    }
}