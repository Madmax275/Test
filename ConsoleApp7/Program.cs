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

        int totalSum = nums.Sum();
        int targetSum = totalSum - x;

        if (targetSum < 0)
        {
            return -1;
        }

        int left = 0;
        int right = nums.Length - 1;
        int operations = 0;

        while (left <= right)
        {
            if (x == 0)
            {
                return operations;
            }

            if (x >= nums[left])
            {
                x -= nums[left];
                left++;
            }
            else if (x >= nums[right])
            {
                x -= nums[right];
                right--;
            }
            else
            {
                break;
            }

            operations++;
        }

        return x == 0 ? operations : -1;


    }
}





