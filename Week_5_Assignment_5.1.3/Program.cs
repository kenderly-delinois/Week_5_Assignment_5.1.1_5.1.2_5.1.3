namespace Week_5_Assignment_5._1._3
{
    internal class Program
    {
        static bool IntArray (int[] nums)
        {
            Dictionary<int, int> num = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) // Looping thru the array
            {
                if (num.ContainsKey(nums[i])) 
                {
                  return true;
                }
                num[nums[i]] = 1; 
            } 
            return false;   
        }

            
        
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 5, 4, 6, 8, 9};
            int[] nums2 = { 1, 2, 3, 3, 8, 7, 7, 5};
            int[] nums3 = { 1, 2, 3, 0, 7, 0, 3, 1};

            Console.WriteLine(IntArray(nums1));
            Console.WriteLine(IntArray(nums2));
            Console.WriteLine(IntArray(nums3));
        }
    }
}
