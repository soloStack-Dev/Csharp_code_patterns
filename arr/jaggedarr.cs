namespace arr
{
    public class jaggedArr
    {
        static void Main()
        {
            int[][] nums = new int[2][]
            {
                new int[3] {10, 20, 30},
                new int[2] {40, 50}
            };
            foreach(int[] num in nums)
            {
                foreach(int n in num)
                {
                    Console.WriteLine($"[{n}]");
                }
            }
        }
    }
}