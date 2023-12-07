class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int x = 0;
        Test test = new Test();
        int a = test.Pointers(ref nums,ref x);
        Console.WriteLine(a);
        Console.ReadKey();
    }

   
}

class Test{
   

    public  int  Pointers(ref int[] nums, ref int x)
    {
        int n = nums.Length;
        int totalSum = 0;

        
        foreach (var num in nums)
        {
            totalSum += num;
        }

       
        int targetSum = totalSum - x;

        
        if (targetSum < 0)
        {
            return -1;
        }

        
        int currentSum = 0;
        int left = 0;
        int minOperations = int.MaxValue;

        
        for (int right = 0; right < n; right++)
        {
            currentSum += nums[right];

            
            while (currentSum >= targetSum)
            {
                
                minOperations = Math.Min(minOperations, n - (right - left + 1));

                
                currentSum -= nums[left];

                
                left++;
            }
        }

        
        return minOperations == int.MaxValue ? -1 : minOperations;
    }
}





