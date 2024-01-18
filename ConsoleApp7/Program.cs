class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 1, 4, 2, 3 };
        int x = 5;
        Test test = new Test();
        int a = test.Pointers(ref nums, ref x);
        Console.WriteLine(a);
        Console.ReadKey();
    }

   
}

class Test{
   
    public int Pointers(ref int[] nums, ref int x)
    {

        int targetSum = nums.Sum() - x;
        int maxSubarrayLength = -1;
        int currentSum = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            currentSum += nums[right];

            while (currentSum > targetSum && left <= right)
            {
                currentSum -= nums[left];
                left++;
            }

            if (currentSum == targetSum)
            {
                maxSubarrayLength = Math.Max(maxSubarrayLength, right - left + 1);
            }
        }

        return maxSubarrayLength != -1 ? nums.Length - maxSubarrayLength : -1;
    }


}






