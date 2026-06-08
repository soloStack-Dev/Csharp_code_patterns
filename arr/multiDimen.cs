namespace arr
{
    public class multiDimen
    {
        static void Main()
        {
            int[,] nums = new int[2, 3];
            nums[0, 0] = 10;
            nums[0, 1] = 20;
            nums[0, 2] = 30;
            nums[1, 0] = 40;
            nums[1, 1] = 50;
            nums[1, 2] = 60;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"[{nums[0, 0]}],[{nums[0, 1]}],[{nums[0, 2]}]");
            Console.WriteLine($"[{nums[1, 0]}],[{nums[1, 1]}],[{nums[1, 2]}]");
            Console.WriteLine("----------------------------------------------");

            foreach(int num in nums)
            {
                Console.WriteLine($"[{num}]");
            }
            Console.WriteLine("----------------------------------------------");
            
        }
    }
}