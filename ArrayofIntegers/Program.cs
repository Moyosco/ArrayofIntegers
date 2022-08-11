namespace ArrayofIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 25, 15, 10, 7, 56, 100, 63, 71, };
            int temp;
            
            for (int i = 0; i < 7; i++)
            {
                for (int j = i +1; j < 8; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
                //Console.WriteLine(string.Join(" ", num));
                //Console.WriteLine(num)
            }
            Console.WriteLine("Array in Descending order: ");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

        }
    }
}