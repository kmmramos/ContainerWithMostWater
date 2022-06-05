namespace Array_SumOfTarget
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                Console.Write("Please enter the size of your array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] height = new int[size];
                for (int i = 0; i < height.Length; i++)
                {
                    Console.Write("Please enter your number: ");
                    height[i] = Convert.ToInt32(Console.ReadLine());
                }

                int answer;
                answer = ContainerWithMostWater(height);
                Console.WriteLine("Here is the area that contains the most water: {0}", Convert.ToString(answer));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //OPTIMIZED SOLUTION
        public static int ContainerWithMostWater(int[] height)
        {
            int p1 = 0, p2 = height.Length - 1, maxArea = 0;
            while (p1 < p2)
            {
                int h = Math.Min(height[p1], height[p2]);
                int w = p2 - p1;
                int a = h * w;
                maxArea = Math.Max(maxArea, a);

                if (height[p1] <= height[p2])
                {
                    p1++;
                }
                else
                {
                    p2--;
                }
            }
            return maxArea;
        }

    }
}