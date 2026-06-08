namespace arr
{
    public class singleDimention
    {
        static void Main()
        {
            int[] nums = new int[5];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            nums[3] = 40;
            nums[4] = 50;

            Console.WriteLine(nums[3]);

            foreach(int num in nums)
            {
                Console.WriteLine($"[{num}]");
            }

            string[] fruits = new string[5] {"apple", "orange", "banana", "peach", "peach"};
            foreach(string fruit in fruits)
            {
                Console.WriteLine($"The fruit is {fruit}");
            }

            string[] operating_system = {"Windows", "Mac", "Unix", "Linux"};
            for(int i = 0; i < operating_system.Length; i++)
            {
                Console.WriteLine($"The operating system is {operating_system[i]}");
            }

        }
    }
}