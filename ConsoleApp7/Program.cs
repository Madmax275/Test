class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 3, 2, 20, 1, 1, 3 };
        int x = 10;
        Test test = new Test();
        int a = test.Pointers(ref nums, ref x);
        Console.WriteLine(a);
        Console.ReadKey();
    }

   
}

class Test{
   
    public int Pointers(ref int[] nums, ref int x)
    {
        
        int totalSum = nums.Sum();
        int operation = 0;

        int targetSum = totalSum - x;

        if (targetSum < 0)
        {
            return -1;
        }

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            if (x == 0)
            {
                return operation;
            }

            if (x < 0 || left > right)
            {
                break;
            }

            if (x >= nums[left] && nums[left] <= nums[right])
            {
                x -= nums[left];
                left++;
                operation++;
            }
            else
            {
                x -= nums[right];
                right--;
                operation++;
            }
        }

        return x == 0 ? operation : -1;

       
    }
}





