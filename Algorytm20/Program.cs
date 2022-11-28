namespace Algorytm20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            int middleValue = input.Count / 2;

            if (input.Count % 2 != 0)
            {
                for (int i = middleValue; i > 0; i--)
                {
                    output.Add(input[middleValue - i]);
                    output.Add(input[middleValue + i]);
                }
                output.Add(middleValue + 1);
            }
            else
            {
                for (int i = middleValue; i > 0; i--)
                {
                    output.Add(input[middleValue - i]);
                    output.Add(input[middleValue + (i - 1)]);
                }
            }

            foreach (int i in output)
                Console.Write($" {i}, ");
        }
    }
}