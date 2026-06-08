namespace arr
{
    public class arrayA
    {
        static void Main()
        {
            int[] nums = {34,89,99,12,100,55};

            foreach(int num in nums)
            {
                Console.WriteLine($"[{num}]");
            }
            Console.WriteLine("----------------------------------------------");
            //sort the arrays
            nums.Sort();
            Console.WriteLine(string.Join(",", nums));
            Console.WriteLine("----------------------------------------------");
            //reverse the arrays
            Array.Reverse(nums);
            Console.WriteLine(string.Join(",", nums));
            Console.WriteLine("----------------------------------------------");

            int idx = Array.BinarySearch(nums, 34);
            Array.Copy(nums, idx, nums, 0, nums.Length - idx);
            Console.WriteLine(string.Join(",", nums));
            Console.WriteLine("----------------------------------------------");
        }
    }
}